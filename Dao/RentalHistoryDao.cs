using Microsoft.Data.SqlClient;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma.Dao
{
    internal class RentalHistoryDao
    {
        private readonly string _connectionString = DotNetEnv.Env.GetString("Connection_String");

        private const string insert = @"
            INSERT INTO tbl_rentalHistory (
                Vehicle_id, User_id, Rental_date, Rental_expiration, Rental_value    
            ) VALUES (
                @Vehicle_id, @User_id, @Rental_date, @Rental_expiration, @Rental_value
            );";

        // Usando para atualizar o dia que o veículo foi devolvido, no caso de cancelamento
        private const string _update = @"
            UPDATE tbl_rentalHistory
            SET
                Rental_expiration=@Rental_expiration
            WHERE 
                User_id=@User_id
        ";

        // Comando parcial, para que eu possa buscar tanto userId quanto por vehicleId
        private const string _list = @"SELECT * FROM tbl_rentalHistory WHERE ";

        public RentalHistoryDao()
        {
            string comand = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbl_rentalHistory' AND schema_id = SCHEMA_ID('dbo'))
                BEGIN
                    CREATE TABLE [dbo].[tbl_rentalHistory] (
                        [Id]                INT IDENTITY (1, 1) NOT NULL PRIMARY KEY, 
                        [Vehicle_id]        INT NOT NULL, 
                        [User_id]           INT NOT NULL, 
                        [Rental_date]       DATETIME NOT NULL, 
                        [Rental_expiration] DATETIME NOT NULL, 
                        [Rental_value]      FLOAT NOT NULL
                    );
                END;";
            using SqlConnection conn = new(_connectionString);
            using SqlCommand cmd = new(comand, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Erro: " + e.Message);
            }
        }

        // Funções completas
        public List<RentalHistory> ListVehicle(bool vehicleId, int id)
        {
            using SqlConnection conn = new(_connectionString);
            using SqlCommand cmd = new();
            cmd.Connection = conn;
            if (vehicleId)
            {
                cmd.CommandText = _list + "Vehicle_id = @Vehicle_id;";
                cmd.Parameters.AddWithValue("@Vehicle_id", id);
            }
            else
            {
                cmd.CommandText = _list + "User_id = @User_id;";
                cmd.Parameters.AddWithValue("@User_id", id);
            }
            List<RentalHistory> history = new();

            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                history.Add(new RentalHistory()
                {
                    Id = reader.GetInt32(0),
                    VehicleId = reader.GetInt32(1),
                    UserId = reader.GetInt32(2),
                    RentalDate = reader.GetDateTime(3),
                    RentalExpiration = reader.GetDateTime(4),
                    RentalValue = reader.GetDouble(5)
                });
            }
            return history;
        }

        // Funções de transation
        public void Save(SqlTransaction transaction, SqlConnection conn, RentalHistory history)
        {
            using SqlCommand cmd = new(insert, conn, transaction);
            cmd.Parameters.AddWithValue("@Vehicle_id", history.VehicleId);
            cmd.Parameters.AddWithValue("@User_id", history.UserId);
            cmd.Parameters.AddWithValue("@Rental_date", history.RentalDate);
            cmd.Parameters.AddWithValue("@Rental_expiration", history.RentalExpiration);
            cmd.Parameters.AddWithValue("@Rental_value", history.RentalValue);
            if (cmd.ExecuteNonQuery() == 0) throw new Exception("Erro ao salvar esse veículo no historico.");
        }

        public void UpdateRentalExpiration(
            SqlTransaction transaction, SqlConnection conn, int userId, DateTime rentalExpiration
        )
        {
            using SqlCommand cmd = new(_update, conn, transaction);
            cmd.Parameters.AddWithValue("@Rental_expiration", rentalExpiration);
            cmd.Parameters.AddWithValue("@User_id", userId);
            if (cmd.ExecuteNonQuery() == 0) throw new Exception("Erro ao atualizar a data de devolução.");
        }
    }

    public class RentalHistory
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int UserId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime RentalExpiration { get; set; }
        public double RentalValue { get; set; }
    }
}
