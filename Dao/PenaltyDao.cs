using System.Data;
using System.Data.SqlClient;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma.Dao
{
    internal class PenaltyDao
    {
        private readonly string ConnectionString = "Data Source=LAPTOP-9AQEBANA;Initial Catalog=ProjetoSemestral;Integrated Security=True;Encrypt=True";

        private readonly string save = "INSERT INTO tbl_penalty (" +
            "OwnerId, Name, Cost) VALUES (" +
            "@OwnerId, @Name, @Cost);";

        private readonly string update = "UPDATE tbl_penalty SET " +
            "Name=@Name, Cost=@Cost WHERE Id=@Id";

        private readonly string list = "SELECT * FROM tbl_penalty WHERE OwnerId=@OwnerId;";

        private readonly string delete = "DELETE FROM tbl_penalty WHERE id=@id;";

        public class Penalty
        {
            private string name = "";

            public int Id { get; set; }
            public int OwnerId { get; set; }
            public string Name { get => name; set =>  name = value; }
            public double Cost { get; set; }
        }

        public PenaltyDao()
        {
            using (SqlConnection conn = new(ConnectionString))
            {
                conn.Open();
                string comand = "IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbl_penalty' AND schema_id = SCHEMA_ID('dbo'))" +
                    "BEGIN\n" +
                    "CREATE TABLE [dbo].[tbl_penalty] (" +
                        "[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, " +
                        "[OwnerId] INT NOT NULL, " +
                        "[Name] VARCHAR(30) NOT NULL, " +
                        "[Cost] FLOAT NOT NULL " +
                        "FOREIGN KEY(OwnerId) REFERENCES tbl_user(Id) ON DELETE CASCADE" +
                        "); " +
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
                        cmd.Parameters.AddWithValue("@Cost", item.Cost);

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

        public bool Update(List<Penalty> penaltys) 
        {
            using (SqlConnection conn = new(ConnectionString)) 
            {
                using (SqlCommand cmd = new(update, conn))
                {
                    try
                    {
                        conn.Open();
                        foreach (Penalty penalty in penaltys)
                        {
                            cmd.Parameters.AddWithValue("@Id", penalty.Id);
                            cmd.Parameters.AddWithValue("@Name", penalty.Name);
                            cmd.Parameters.AddWithValue("@Cost", penalty.Cost);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERRO: " + ex.Message, "MESSAGEM DE DEBUG");
                        return false;
                    }
                    return true;
                }
            }
        }

        public List<Penalty> List(int ownerId)
        {
            List<Penalty> penaltyList = new();

            using (SqlConnection conn = new(ConnectionString))
            {
                using (SqlCommand cmd = new(list, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@OwnerId", ownerId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Penalty penalty = new();
                        penalty.Id = reader.GetInt32("id");
                        penalty.Name = reader.GetString("Name");
                        penalty.Cost = reader.GetDouble("Cost");

                        penaltyList.Add(penalty);
                    }
                    return penaltyList;
                }
            }
        }

        public bool Delete(List<int> ids)
        {
            using (SqlConnection conn = new(ConnectionString))
            {
                using (SqlCommand cmd = new(delete, conn))
                {
                    try
                    {
                        conn.Open();
                        foreach (int id in ids)
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }
                        return true;
                    } catch (Exception ex)
                    {
                        MessageBox.Show("ERRO: " + ex.Message, "MESSAGEM DE DEBUG");
                        return false;
                    }
                }
            }
        }
    }
}
