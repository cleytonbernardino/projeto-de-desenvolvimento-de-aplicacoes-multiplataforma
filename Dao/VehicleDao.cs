﻿using System.Data;
using System.Data.SqlClient;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma.Dao
{
    internal class VehicleDao
    {
        // String de conexão
        readonly string connectionString = @"Data Source=LAPTOP-9AQEBANA;Initial Catalog=ProjetoSemestral;Integrated Security=True;Encrypt=True";

        // Comando Select
        private const string select = "SELECT * FROM tbl_vehicle WHERE id=@id;";

        // Comando List
        private const string list = "SELECT id, License_plate as Placa, Mileage, Color, Brand, Model, Renavam FROM tbl_vehicle";

        // Comando List com like
        private const string serch = "SELECT License_plate as Placa, Mileage, Color, Brand, Model, Renavam FROM tbl_vehicle WHERE License_plate LIKE @License_plate";

        // Comando Insert
        private const string insert = "INSERT INTO tbl_vehicle (" +
            "License_plate, Brand, Model, Model_year, Chassis_number, Renavam, Color, Fuel_type, Mileage, Air_conditioning, Electric_windows, Electric_locks, Licensed, Direction" +
            ") VALUES (@License_plate, @Brand, @Model, @Model_year, @Chassis_number, @Renavam, @Color, @Fuel_type, @Mileage, @Air_conditioning, @Electric_windows, @Electric_locks, @Licensed, @Direction);" +
            "SELECT CAST(SCOPE_IDENTITY() AS INT);";

        // Comando Update
        private const string update = "UPDATE tbl_vehicle SET " +
            "License_plate=@License_plate, Brand=@Brand, Model=@Model, Model_year=@Model_year, Chassis_number=@Chassis_number, Renavam=@Renavam, Color=@Color, Fuel_type=@Fuel_type," +
            "Mileage=@Mileage, Air_conditioning=@Air_conditioning, Electric_windows=@Electric_windows, Electric_locks=@Electric_locks, Licensed=@Licensed, Direction=@Direction " +
            "WHERE id=@id";

        // Comando Delete
        private const string delete = "DELETE FROM tbl_vehicle WHERE id=@id;";

        // Public var
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string ChassiNumber { get; set; }
        public string Color { get; set; }
        public string FuelType { get; set; }
        public string Obs { get; set; }
        public string Direction { get; set; }
        public string Renavam { get; set; }
        public int Mileage { get; set; }
        public bool AirConditioning { get; set; }
        public bool EletricWindows { get; set; }
        public bool EletricLocks { get; set; }
        public bool Licensed { get; set; }
        public DateTime ModelYear { get; set; }

        // Refazer isso para deixar somente que ele crie a tabela ao inves de copiar o django
        private void InitBD()
        {
            string fileName = "vehicle"; // Nome dos arquivos sql
            Int16 fileNumber = 1; // Número do arquivo
            string filePath = @"C:\Users\cleyt\source\repos\ProjetoDesenvolvimentoAplicacoesMultplataforma\Migrations\"; //Caminho dos arquivo
            string fullPath = ""; // Caminho completo do arquivo
            string sqlScript = ""; // script sql

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    while (true)
                    {
                        fullPath = filePath + fileName + fileNumber + ".sql";
                        try
                        {
                            sqlScript = File.ReadAllText(fullPath);
                            using (SqlCommand cmd = new SqlCommand(sqlScript, conn))
                            {
                                cmd.ExecuteNonQuery();
                            }
                            fileNumber++;
                        }
                        catch (Exception ex)
                        {
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Conectar ao banco de dados: " + ex.Message, "Erro");
                }
            }
        }

        public VehicleDao()
        {
            // Cria uma nova tabela e faz todas as alterações necessarias
            InitBD();
        }

        public bool Select()
        {
            if (Id <= 0) return false;

            using (SqlConnection conn = new(connectionString))
            {
                using (SqlCommand cmd = new(select, conn))
                {
                    conn.Open();
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", Id);
                        SqlDataReader reader =  cmd.ExecuteReader();
                        reader.Read();

                        LicensePlate = reader.GetString("License_plate");
                        Brand = reader.GetString("Brand");
                        Model = reader.GetString("Model");
                        ModelYear = reader.GetDateTime("Model_year");
                        ChassiNumber = reader.GetString("Chassis_number");
                        Renavam = reader.GetString("Renavam");
                        Color = reader.GetString("Color");
                        FuelType = reader.GetString("Fuel_type");
                        Mileage = reader.GetInt32("Mileage");
                        AirConditioning = reader.GetBoolean("Air_conditioning");
                        EletricWindows = reader.GetBoolean("Electric_windows");
                        EletricLocks = reader.GetBoolean("Electric_locks");
                        Licensed = reader.GetBoolean("Licensed");
                        Direction = reader.GetString("Direction");
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new(connectionString))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand(list, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable Search()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            using (SqlConnection conn = new(connectionString))
            {
                //conn.Open();
                using (SqlCommand cmd = new(serch, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@License_plate", LicensePlate + "%");
                    da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public int Save()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(insert, conn))
                    {
                        cmd.Parameters.AddWithValue("@License_plate", LicensePlate);
                        cmd.Parameters.AddWithValue("@Brand", Brand);
                        cmd.Parameters.AddWithValue("@Model", Model);
                        cmd.Parameters.AddWithValue("@Model_year", ModelYear);
                        cmd.Parameters.AddWithValue("@Chassis_number", ChassiNumber);
                        cmd.Parameters.AddWithValue("@Renavam", Renavam);
                        cmd.Parameters.AddWithValue("@Color", Color);
                        cmd.Parameters.AddWithValue("@Fuel_type", FuelType);
                        cmd.Parameters.AddWithValue("@Mileage", Mileage);
                        cmd.Parameters.AddWithValue("@Air_conditioning", AirConditioning);
                        cmd.Parameters.AddWithValue("@Electric_windows", EletricWindows);
                        cmd.Parameters.AddWithValue("@Electric_locks", EletricLocks);
                        cmd.Parameters.AddWithValue("@Licensed", Licensed);
                        cmd.Parameters.AddWithValue("@Direction", Direction);
                        
                        Id = (int)cmd.ExecuteScalar();
                        return Id;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                    return -1;
                }
            }
        }

        public int Update()
        {
            if (Id == 0) return -1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(update, conn))
                {
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.Parameters.AddWithValue("@License_plate", LicensePlate);
                    cmd.Parameters.AddWithValue("@Brand", Brand);
                    cmd.Parameters.AddWithValue("@Model", Model);
                    cmd.Parameters.AddWithValue("@Model_year", ModelYear);
                    cmd.Parameters.AddWithValue("@Chassis_number", ChassiNumber);
                    cmd.Parameters.AddWithValue("@Renavam", Renavam);
                    cmd.Parameters.AddWithValue("@Color", Color);
                    cmd.Parameters.AddWithValue("@Fuel_type", FuelType);
                    cmd.Parameters.AddWithValue("@Mileage", Mileage);
                    cmd.Parameters.AddWithValue("@Air_conditioning", AirConditioning);
                    cmd.Parameters.AddWithValue("@Electric_windows", EletricWindows);
                    cmd.Parameters.AddWithValue("@Electric_locks", EletricLocks);
                    cmd.Parameters.AddWithValue("@Licensed", Licensed);
                    cmd.Parameters.AddWithValue("@Direction", Direction);
                    try
                    {
                        return cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                        return -1;
                    }
                }
            }
        }

        /// <summary>
        /// Remove o veiculo da placa atual, é nessario definir uma lincense_plate antes
        /// </summary>
        /// <returns>Retorna a quantidade de linhas afetadas (-1 é o retorno de um erro).</returns>
        public bool Delete()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(delete, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", Id);
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
}
