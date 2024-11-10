using System.Data;
using System.Data.SqlClient;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma.Dao
{
    internal class PenaltyDao
    {
        private readonly string ConnectionString = "Data Source=LAPTOP-9AQEBANA;Initial Catalog=ProjetoSemestral;Integrated Security=True;Encrypt=True";

        private readonly string save = "INSERT INTO tbl_penalty (" +
            "OwnerId, Name, Value) VALUES (" +
            "@OwnerId, @Name, @Value);";

        private readonly string list = "SELECT * FROM tbl_penalty WHERE OwnerId=@OwnerId;";

        public class Penalty
        {
            private string name = "";

            public int Id { get; set; }
            public int OwnerId { get; set; }
            public string Name { get => name; set => name = value; }
            public float Value { get; set; }
        }

        public PenaltyDao()
        {
            using (SqlConnection conn = new(ConnectionString))
            {
                conn.Open();
                string comand = "IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbl_penalty' AND schema_id = SCHEMA_ID('dbo'))" +
                    "BEGIN\n" +
                    "CREATE TABLE [dbo].[tbl_penalty] (" +
                        "[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY," + 
                        "[OwnerId] INT NOT NULL, " + 
                        "[Name] VARCHAR(30) NOT NULL," + 
                        "[Value] FLOAT NOT NULL" + 
                        "FOREIGN KEY(OwnerId) REFERENCES tbl_user(id) ON DELETE CASCADE" + 
                    "END;";
                using (SqlCommand cmd = new SqlCommand(comand, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool Save(List<Penalty> penalty)
        {
            using (SqlConnection conn = new(ConnectionString)) 
            {
                using (SqlCommand cmd = new(save, conn))
                {
                    conn.Open();
                    foreach (Penalty item in penalty)
                    {
                        cmd.Parameters.AddWithValue("@OwnerId", item.OwnerId);
                        cmd.Parameters.AddWithValue("@Name", item.Name);
                        cmd.Parameters.AddWithValue("@Value", item.Value);

                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro: " + ex.Message, "MESSAGE DE DEBUG");
                            return false;
                        }
                    }
                    return true;
                }
            }
        }

        public List<Penalty> List()
        {
            List<Penalty> penaltyList = new();
            Penalty penalty = new();

            using (SqlConnection conn = new(ConnectionString))
            {
                using (SqlCommand cmd = new(list, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        penalty.OwnerId = reader.GetInt32("OwnerId");
                        penalty.Name = reader.GetString("Name");
                        penalty.Value = reader.GetFloat("Value");

                        penaltyList.Add(penalty);
                    }
                    return penaltyList;
                }
            }
        }
    }
}
