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
        private const string _list = "SELECT id, License_plate, Mileage, Color, Brand, Model, Rented_by, Rental_expiration FROM tbl_vehicle";

        // Comando List com like
        private const string _search = "SELECT id, License_plate, Mileage, Color, Brand, Model, Rented_by, Rental_expiration FROM tbl_vehicle" +
            " WHERE License_plate LIKE @License_plate";

        // Comando Insert
        private const string _insert = "INSERT INTO tbl_vehicle (" +
            "License_plate, Brand, Model, Model_year, Chassis_number, Renavam, Color, Fuel_type, Mileage, Air_conditioning, Electric_windows, Electric_locks, Licensed, Direction" +
            ") VALUES (@License_plate, @Brand, @Model, @Model_year, @Chassis_number, @Renavam, @Color, @Fuel_type, @Mileage, @Air_conditioning, @Electric_windows, @Electric_locks, @Licensed, @Direction);" +
            "SELECT CAST(SCOPE_IDENTITY() AS INT);";

        // Comando Update
        private const string _update = "UPDATE tbl_vehicle SET " +
            "License_plate=@License_plate, Brand=@Brand, Model=@Model, Model_year=@Model_year, Chassis_number=@Chassis_number, Renavam=@Renavam, Color=@Color, Fuel_type=@Fuel_type," +
            "Mileage=@Mileage, Air_conditioning=@Air_conditioning, Electric_windows=@Electric_windows, Electric_locks=@Electric_locks, Licensed=@Licensed, Direction=@Direction " +
            "WHERE id=@id";

        // Comando Delete
        private const string _delete = "DELETE FROM tbl_vehicle WHERE id=@id;";

        // Refazer isso para deixar somente que ele crie a tabela ao inves de copiar o django
        private void InitBD()
        {
            string command = "IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbl_vehicle' AND schema_id = SCHEMA_ID('dbo'))" +
                "BEGIN\n" +
                "CREATE TABLE [dbo].[tbl_vehicle] (" +
                    "[id]                INT IDENTITY(1,1) PRIMARY KEY NOT NULL," +
                    "[Rented_by]         INT NULL," +
                    "[Rental_expiration] DATE NULL," +
                    "[License_plate]     NCHAR(7)  UNIQUE NOT NULL," +
                    "[Brand] VARCHAR(25) NOT NULL," +
                    "[Model]             VARCHAR(55)  NOT NULL," +
                    "[Model_year]        DATE NOT NULL," +
                    "[Chassis_number]    NCHAR(17)    NOT NULL," +
                    "[Renavam]           NCHAR(11)    NOT NULL," +
                    "[Color]             VARCHAR(25)  NOT NULL," +
                    "[Fuel_type]         VARCHAR(15)  NOT NULL," +
                    "[Mileage]           INT NOT NULL," +
                    "[OBS]               VARCHAR(255) NULL," +
	                "[Direction]         VARCHAR(15)  NOT NULL," +
                    "[Air_conditioning]  BIT DEFAULT 0 NOT NULL," +
                    "[Electric_windows]  BIT DEFAULT 0 NOT NULL," +
                    "[Electric_locks]    BIT DEFAULT 0 NOT NULL," +
                    "[Licensed]          BIT DEFAULT 0 NOT NULL" +
                "); END;";
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
            // Cria uma nova tabela e faz todas as alterações necessarias
            InitBD();
        }

        public Vehicle? Select(int id)
        {
            using (SqlConnection conn = new(_connectionString))
            {
                using (SqlCommand cmd = new(_select, conn))
                {
                    conn.Open();
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        SqlDataReader reader =  cmd.ExecuteReader();
                        if (!reader.Read()) return null;
                        return new Vehicle() {
                            LicensePlate = reader.GetString("License_plate"),
                            Brand = reader.GetString("Brand"),
                            Model = reader.GetString("Model"),
                            ModelYear = reader.GetDateTime("Model_year"),
                            ChassiNumber = reader.GetString("Chassis_number"),
                            Renavam = reader.GetString("Renavam"),
                            Color = reader.GetString("Color"),
                            FuelType = reader.GetString("Fuel_type"),
                            Mileage = reader.GetInt32("Mileage"),
                            AirConditioning = reader.GetBoolean("Air_conditioning"),
                            EletricWindows = reader.GetBoolean("Electric_windows"),
                            EletricLocks = reader.GetBoolean("Electric_locks"),
                            Licensed = reader.GetBoolean("Licensed"),
                            Direction = reader.GetString("Direction"),
                        };
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                        return null;
                    }
                }
            }
        }

        public List<Vehicle> Listar()
        {
            List<Vehicle> vehicles = new();
            using (SqlConnection conn = new(_connectionString))
            {
                using(SqlCommand cmd = new(_list, conn))
                {
                    conn.Open();
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
                }
            }
            return vehicles;
        }

        public List<Vehicle> Search(string licensePlate)
        {
            List<Vehicle> vehicles = new();
            using (SqlConnection conn = new(_connectionString))
            {
                using (SqlCommand cmd = new(_search, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@License_plate", licensePlate + "%");
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
                }
            }
            return vehicles;
        }

        public int Save(Vehicle vehicle)
        {
            using (SqlConnection conn = new(_connectionString))
            {
                using (SqlCommand cmd = new(_insert, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@License_plate", vehicle.LicensePlate);
                    cmd.Parameters.AddWithValue("@Brand", vehicle.Brand);
                    cmd.Parameters.AddWithValue("@Model", vehicle.Model);
                    cmd.Parameters.AddWithValue("@Model_year", vehicle.ModelYear);
                    cmd.Parameters.AddWithValue("@Chassis_number", vehicle.ChassiNumber);
                    cmd.Parameters.AddWithValue("@Renavam", vehicle.Renavam);
                    cmd.Parameters.AddWithValue("@Color", vehicle.Color);
                    cmd.Parameters.AddWithValue("@Fuel_type", vehicle.FuelType);
                    cmd.Parameters.AddWithValue("@Mileage", vehicle.Mileage);
                    cmd.Parameters.AddWithValue("@Air_conditioning", vehicle.AirConditioning);
                    cmd.Parameters.AddWithValue("@Electric_windows", vehicle.EletricWindows);
                    cmd.Parameters.AddWithValue("@Electric_locks", vehicle.EletricLocks);
                    cmd.Parameters.AddWithValue("@Licensed", vehicle.Licensed);
                    cmd.Parameters.AddWithValue("@Direction", vehicle.Direction);

                    try
                    {
                        return (int)cmd.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message, "Messagem de DEBUG(vehicleDao|Save)");
                        return -1;
                    }
                }
            }
        }

        public int Update(Vehicle vehicle)
        {
            using (SqlConnection conn = new(_connectionString))
            {
                using (SqlCommand cmd = new(_update, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", vehicle.Id);
                    cmd.Parameters.AddWithValue("@License_plate", vehicle.LicensePlate);
                    cmd.Parameters.AddWithValue("@Brand", vehicle.Brand);
                    cmd.Parameters.AddWithValue("@Model", vehicle.Model);
                    cmd.Parameters.AddWithValue("@Model_year", vehicle.ModelYear);
                    cmd.Parameters.AddWithValue("@Chassis_number", vehicle.ChassiNumber);
                    cmd.Parameters.AddWithValue("@Renavam", vehicle.Renavam);
                    cmd.Parameters.AddWithValue("@Color", vehicle.Color);
                    cmd.Parameters.AddWithValue("@Fuel_type", vehicle.FuelType);
                    cmd.Parameters.AddWithValue("@Mileage", vehicle.Mileage);
                    cmd.Parameters.AddWithValue("@Air_conditioning", vehicle.AirConditioning);
                    cmd.Parameters.AddWithValue("@Electric_windows", vehicle.EletricWindows);
                    cmd.Parameters.AddWithValue("@Electric_locks", vehicle.EletricLocks);
                    cmd.Parameters.AddWithValue("@Licensed", vehicle.Licensed);
                    cmd.Parameters.AddWithValue("@Direction", vehicle.Direction);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                        return -1;
                    }
                }
            }
        }

        public bool Delete(int id)
        {
            using (SqlConnection conn = new(_connectionString))
            {
                using (SqlCommand cmd = new(_delete, conn))
                {
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
            }
        }

    }
    public class Vehicle
    {
        public int Id { get; set; }
        public int RentedBy { get; set; }
        public DateTime RentalExpiration { get; set; }
        public string LicensePlate { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string ChassiNumber { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string FuelType { get; set; } = string.Empty;
        public string Obs { get; set; } = string.Empty;
        public string Direction { get; set; } = string.Empty;
        public string Renavam { get; set; } = string.Empty;
        public int Mileage { get; set; }
        public bool AirConditioning { get; set; }
        public bool EletricWindows { get; set; }
        public bool EletricLocks { get; set; }
        public bool Licensed { get; set; }
        public DateTime ModelYear { get; set; }

    }
}
