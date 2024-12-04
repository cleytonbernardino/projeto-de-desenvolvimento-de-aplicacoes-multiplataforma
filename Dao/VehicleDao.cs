using Microsoft.Data.SqlClient;
using System.Data;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma.Dao
{
    internal class VehicleDao
    {
        // String de conexão
        private readonly string _connectionString = DotNetEnv.Env.GetString("Connection_String");

        // Comando Select
        private const string _select = "SELECT * FROM tbl_vehicle WHERE id=@id;";

        // Comando List
        private const string _list = "SELECT id, License_plate, Color, Daily_vehicle_rate, Model, Rented_by, Rental_expiration FROM tbl_vehicle";

        // Comando Insert
        private const string _insert = @"
            INSERT INTO tbl_vehicle (
                Rented_by, Rental_expiration, License_plate, Brand, Model, Model_year, Chassis_number, Renavam, Daily_vehicle_rate, Color, Fuel_type, Mileage, 
                Air_conditioning, Electric_windows, Electric_locks, Licensed, Direction, OBS
            ) 
            VALUES (
                @Rented_by, @Rental_expiration, @License_plate, @Brand, @Model, @Model_year, @Chassis_number, @Renavam, @Daily_vehicle_rate, @Color, 
                @Fuel_type, @Mileage, @Air_conditioning, @Electric_windows, @Electric_locks, @Licensed, @Direction, @OBS
            ); 
            SELECT CAST(SCOPE_IDENTITY() AS INT);";

        // Comando Update
        private const string _update = @"
            UPDATE tbl_vehicle
            SET 
                License_plate=@License_plate, Brand=@Brand, 
                Model=@Model, Model_year=@Model_year, 
                Chassis_number=@Chassis_number, Renavam=@Renavam, 
                Daily_vehicle_rate=@Daily_vehicle_rate, Color=@Color, 
                Fuel_type=@Fuel_type, Mileage=@Mileage, Air_conditioning=@Air_conditioning, 
                Electric_windows=@Electric_windows, Electric_locks=@Electric_locks, 
                Licensed=@Licensed, Direction=@Direction, OBS=@OBS
            WHERE 
                id=@id;";

        // Atualiza o aluguel
        private const string _updateRental = @"
            UPDATE tbl_vehicle
            SET 
                Rented_by=@Rented_by, Rental_date=@Rental_date, Rental_expiration=@Rental_expiration
            WHERE 
                id=@id;";

        // Comando Delete
        private const string _delete = "DELETE FROM tbl_vehicle WHERE id=@id;";

        // Apagar veiculos com aluguel vencido
        private const string _delteOverdueRent = @"
            UPDATE tbl_vehicle 
            SET 
                Rented_by=0
            WHERE 
                Rental_expiration < @date;";

        private const string _cancelRent = @"
            UPDATE tbl_vehicle 
            SET 
                Rented_by=0
            WHERE 
                id=@id";

        private void InitBD()
        {
            string command = @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbl_vehicle' AND schema_id = SCHEMA_ID('dbo'))
                BEGIN
                CREATE TABLE [dbo].[tbl_vehicle] (
                    [id]                 INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
                    [Rented_by]          INT           NULL,
                    [Rental_date]        DATE          NULL,       
                    [Rental_expiration]  DATE          NULL,       
                    [License_plate]      NCHAR(7) UNIQUE NOT NULL, 
                    [Brand]              VARCHAR(25)   NOT NULL,  
                    [Model]              VARCHAR(55)   NOT NULL,   
                    [Model_year]         NCHAR(4)      NOT NULL,   
                    [Chassis_number]     NCHAR(17)     NOT NULL,   
                    [Renavam]            NCHAR(11)     NOT NULL,   
                    [Daily_vehicle_rate] FLOAT         NOT NULL,   
                    [Color]              VARCHAR(25)   NOT NULL,   
                    [Fuel_type]          VARCHAR(15)   NOT NULL,   
                    [Mileage]            INT           NOT NULL,   
                    [OBS]                VARCHAR(255)  NULL,       
	                [Direction]          VARCHAR(25)   NOT NULL,   
                    [Air_conditioning]   BIT DEFAULT 0 NOT NULL,   
                    [Electric_windows]   BIT DEFAULT 0 NOT NULL,   
                    [Electric_locks]     BIT DEFAULT 0 NOT NULL,   
                    [Licensed]           BIT DEFAULT 0 NOT NULL,   
                    UNIQUE NONCLUSTERED([License_plate] ASC)       
                ); END;";
            using (SqlConnection conn = new(_connectionString))
            {
                using (SqlCommand cmd = new(command, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public VehicleDao()
        {
            InitBD();
        }

        public Vehicle? Select(int id)
        {
            using SqlConnection conn = new(_connectionString);
            using SqlCommand cmd = new(_select, conn);
            conn.Open();
            try
            {
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader =  cmd.ExecuteReader();
                if (!reader.Read()) return null;
                    Vehicle vehicle =  new() {
                        LicensePlate = reader.GetString("License_plate"),
                        RentedBy = reader.GetInt32("Rented_by"),
                        Brand = reader.GetString("Brand"),
                        Model = reader.GetString("Model"),
                        ModelYear = reader.GetString("Model_year"),
                        ChassiNumber = reader.GetString("Chassis_number"),
                        Renavam = reader.GetString("Renavam"),
                        DailyVehicleRate = reader.GetDouble("Daily_vehicle_rate"),
                        Color = reader.GetString("Color"),
                        FuelType = reader.GetString("Fuel_type"),
                        Obs = reader.GetString("OBS"),
                        Mileage = reader.GetInt32("Mileage"),
                        AirConditioning = reader.GetBoolean("Air_conditioning"),
                        EletricWindows = reader.GetBoolean("Electric_windows"),
                        EletricLocks = reader.GetBoolean("Electric_locks"),
                        Licensed = reader.GetBoolean("Licensed"),
                        Direction = reader.GetString("Direction"),
                    };
                if (vehicle.RentedBy > 0) vehicle.RentalExpiration = reader.GetDateTime("Rental_expiration");
                reader.Close();
                return vehicle;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                return null;
            }
        }

        public List<Vehicle> ListVehicle()
        {
            List<Vehicle> vehicles = new();
            Vehicle vehicle;
            using (SqlConnection conn = new(_connectionString))
            {
                using(SqlCommand cmd = new(_list, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int rentedBy = reader.GetInt32("Rented_by");
                        vehicle = new()
                        {
                            Id = reader.GetInt32("id"),
                            RentedBy = rentedBy,
                            LicensePlate = reader.GetString("License_plate"),
                            Color = reader.GetString("Color"),
                            Model = reader.GetString("Model"),
                            DailyVehicleRate = reader.GetDouble("Daily_vehicle_rate"),
                        };
                        if (rentedBy > 0) vehicle.RentalExpiration = reader.GetDateTime("Rental_expiration");
                        vehicles.Add(vehicle);
                    }
                }
            }
            return vehicles;
        }

        public List<Vehicle> Search(string licensePlate)
        {
            List<Vehicle> vehicles = new();
            using SqlConnection conn = new(_connectionString);
            using SqlCommand cmd = new();
            
            conn.Open();
            cmd.Connection = conn;
            if (licensePlate.Contains('#'))
            {
                cmd.CommandText = " WHERE id=@id";
                cmd.Parameters.AddWithValue("@id", int.Parse(licensePlate));
            } else
            {
                cmd.CommandText = " WHERE License_plate LIKE @License_plate";
                cmd.Parameters.AddWithValue("@License_plate", licensePlate + "%");
            }

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int rentedBy = reader.GetInt32("Rented_by");
                Vehicle vehicle = new()
                {
                    Id = reader.GetInt32("id"),
                    RentedBy = rentedBy,
                    LicensePlate = reader.GetString("License_plate"),
                    Color = reader.GetString("Color"),
                    Brand = reader.GetString("Brand"),
                    Model = reader.GetString("Model"),
                };
                if (rentedBy > 0) vehicle.RentalExpiration = reader.GetDateTime("Rental_expiration");
                vehicles.Add(vehicle);
            }
            return vehicles;
        }

        public int Save(Vehicle vehicle)
        {
            using SqlConnection conn = new(_connectionString);
            using SqlCommand cmd = new(vehicle.Id == 0? _insert : _update, conn);

            conn.Open();
            cmd.Parameters.AddWithValue("@Rented_by", 0);
            cmd.Parameters.AddWithValue("@Rental_expiration", DBNull.Value);
            cmd.Parameters.AddWithValue("@License_plate", vehicle.LicensePlate);
            cmd.Parameters.AddWithValue("@Brand", vehicle.Brand);
            cmd.Parameters.AddWithValue("@Model", vehicle.Model);
            cmd.Parameters.AddWithValue("@Model_year", vehicle.ModelYear);
            cmd.Parameters.AddWithValue("@Chassis_number", vehicle.ChassiNumber);
            cmd.Parameters.AddWithValue("@Renavam", vehicle.Renavam);
            cmd.Parameters.AddWithValue("@Daily_vehicle_rate", vehicle.DailyVehicleRate);
            cmd.Parameters.AddWithValue("@Color", vehicle.Color);
            cmd.Parameters.AddWithValue("@Fuel_type", vehicle.FuelType);
            cmd.Parameters.AddWithValue("@OBS", vehicle.Obs);
            cmd.Parameters.AddWithValue("@Mileage", vehicle.Mileage);
            cmd.Parameters.AddWithValue("@Air_conditioning", vehicle.AirConditioning);
            cmd.Parameters.AddWithValue("@Electric_windows", vehicle.EletricWindows);
            cmd.Parameters.AddWithValue("@Electric_locks", vehicle.EletricLocks);
            cmd.Parameters.AddWithValue("@Licensed", vehicle.Licensed);
            cmd.Parameters.AddWithValue("@Direction", vehicle.Direction);

            try
            {
                if (vehicle.Id > 0)
                {
                    cmd.Parameters.AddWithValue("@id", vehicle.Id);
                    cmd.ExecuteNonQuery();
                    return 0;
                }
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Messagem de DEBUG(vehicleDao|Save)");
                return -1;
            }
        }

        public void UpdateRental(
            SqlTransaction transaction, SqlConnection conn, int id, 
            int rentedBy, DateTime rentalDate, DateTime rentalExpiration
        )
        {
            using SqlCommand cmd = new(_updateRental, conn, transaction);
            cmd.Parameters.AddWithValue("@Rented_by", rentedBy);
            cmd.Parameters.AddWithValue("@Rental_date", rentalDate);
            cmd.Parameters.AddWithValue("@Rental_expiration", rentalExpiration);
            cmd.Parameters.AddWithValue("@id", id);
            
            try
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows == 0) throw new Exception("Veículo não encontrado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message, "MESSAGE DE DEBUG|UpdateRental");
                throw new Exception("Veículo não encontrado");
            }
        }
        public bool Delete(int id)
        {
            using SqlConnection conn = new(_connectionString);
            using SqlCommand cmd = new(_delete, conn);

            conn.Open();
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
                return false;
            }
        }

        public void DeleteOverdueRent()
        {
            using SqlConnection conn = new(_connectionString);
            using SqlCommand cmd = new(_delteOverdueRent, conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message, "MESSAGEM DE DEBUG| DeleteOverdueRent");
                throw new Exception(ex.Message);
            }
        }

        public void CancelRent(
            SqlTransaction transaction, SqlConnection conn, int vehicleID
        )
        {
            using SqlCommand cmd = new(_cancelRent, conn, transaction);
            cmd.Parameters.AddWithValue("@id", vehicleID);
            try
            {
                if (cmd.ExecuteNonQuery() == 0) throw new Exception("Veículo não encontrado"); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message, "MESSAGEM DE DEBUG| DeleteOverdueRent");
                throw new Exception(ex.Message);
            }
        }

    }

    public class Vehicle
    {
        public int Id { get; set; } = 0;
        public int RentedBy { get; set; } = 0;
        public DateTime RentalExpiration { get; set; }
        public string LicensePlate { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string ChassiNumber { get; set; } = string.Empty;
        public double DailyVehicleRate { get; set; } = 0;
        public string Color { get; set; } = string.Empty;
        public string FuelType { get; set; } = string.Empty;
        public string Obs { get; set; } = string.Empty;
        public string Direction { get; set; } = string.Empty;
        public string Renavam { get; set; } = string.Empty;
        public string ModelYear { get; set; } = string.Empty;
        public int Mileage { get; set; } = 0;
        public bool AirConditioning { get; set; } = false;
        public bool EletricWindows { get; set; } = false;
        public bool EletricLocks { get; set; } = false;
        public bool Licensed { get; set; } = false;
    }
}
