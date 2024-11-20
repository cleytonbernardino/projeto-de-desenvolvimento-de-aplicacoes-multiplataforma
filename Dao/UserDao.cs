using System.Data;
using System.Data.SqlClient;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma.Dao
{
    internal class UserDao
    {
        private readonly string _connectionString = @"Data Source=LAPTOP-9AQEBANA;Initial Catalog=ProjetoSemestral;Integrated Security=True;Encrypt=True";

        private readonly string insert = "INSERT INTO tbl_user (" +
            "First_name, Last_name, Email, Balance, Date_of_birth, CPF, CNH" +
            ") OUTPUT INSERTED.ID " + 
            "VALUES (@First_name, @Last_name, @Email, @Balance, @Date_of_birth, @CPF, @CNH);";
            //"SELECT CAST(SCOPE_IDENTITY() AS INT);";

        private readonly string update = "UPDATE tbl_user SET " +
            "First_name=@First_name, Last_name=@Last_name, Email=@Email, Balance=@Balance, Date_of_birth=@Date_of_birth" +
            " WHERE id=@id";

        private readonly string select = "SELECT * FROM tbl_user WHERE id=@id;";

        private readonly string search = "SELECT id, First_name as Nome, Last_name as Sobrenome, CPF FROM tbl_user " +
            "WHERE CONCAT(First_name, Last_name) LIKE @CompleteName;";

        private readonly string list = "SELECT id, First_name as Nome, Last_name as Sobrenome, CPF FROM tbl_user;";

        private readonly string delete = "DELETE FROM tbl_user WHERE id=@id;";

        public UserDao()
        {
            using (SqlConnection conn = new(_connectionString))
            {
                conn.Open();
                string comand = "IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbl_user' AND schema_id = SCHEMA_ID('dbo'))" +
                    "BEGIN\n" +
                    "CREATE TABLE [dbo].[tbl_user] (" +
                        "[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, " +
                        "[First_name]      VARCHAR(25)    NOT NULL, " +
                        "[Last_name]       VARCHAR(50)    NOT NULL, " +
                        "[Email]           VARCHAR(255)   NOT NULL, " +
                        "[Balance]         DECIMAL(8, 2)  NOT NULL," +
                        "[Date_of_birth]   DATE           NOT NULL, " +
                        "[CPF]             NCHAR(11)      UNIQUE NOT NULL, " +
                        "[CNH]             NCHAR(9)       NOT NULL);" +
                    "END;";
                using (SqlCommand cmd = new SqlCommand(comand, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public int Save(User user)
        {
            using (SqlConnection conn = new(_connectionString))
            {
                using (SqlCommand cmd = new(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@First_name", user.FirstName);
                    cmd.Parameters.AddWithValue("@Last_name", user.LastName);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@CPF", user.CPF);
                    cmd.Parameters.AddWithValue("@CNH", user.CNH);
                    cmd.Parameters.AddWithValue("@Balance", user.Balance);
                    cmd.Parameters.AddWithValue("@Date_of_birth", user.BirtyDay);
                    try
                    {
                        conn.Open();
                        return (int)cmd.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Salvar: " + ex.Message, "MESSAGE DE DEBUG");
                        return -1;
                    }
                }
            }
        }

        public int Update(User user)
        {
            using (SqlConnection conn = new(_connectionString))
            {
                using (SqlCommand cmd = new(update, conn))
                {
                    cmd.Parameters.AddWithValue("@id", user.Id);
                    cmd.Parameters.AddWithValue("@First_name", user.FirstName);
                    cmd.Parameters.AddWithValue("@Last_name", user.LastName);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Balance", user.Balance);
                    cmd.Parameters.AddWithValue("@Date_of_birth", user.BirtyDay);

                    conn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message, "MESSAGEM DE DEBUG");
                        return -1;
                    }
                }
            }
        }

        public DataTable Search(string completeName)
        {
            DataTable dt = new();
            SqlDataAdapter da;
            using (SqlConnection conn = new(_connectionString))
            {
                using (SqlCommand cmd = new(search, conn))
                {
                    da = new(cmd);
                    cmd.Parameters.AddWithValue("@CompleteName", "%" + completeName + "%");
                    conn.Open();
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable ListUsers()
        {
            DataTable dt = new();
            SqlDataAdapter da;
            using (SqlConnection conn = new(_connectionString))
            {
                using (SqlCommand cmd = new(list, conn))
                {
                    da = new SqlDataAdapter(cmd);
                    conn.Open();
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public User Select(int id)
        {
            using (SqlConnection conn = new(_connectionString))
            {
                using (SqlCommand cmd = new(select, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            return new User()
                            {
                                Id = reader.GetInt32("Id"),
                                FirstName = reader.GetString("First_name"),
                                LastName = reader.GetString("Last_name"),
                                Email = reader.GetString("email"),
                                CPF = reader.GetString("CPF"),
                                CNH = reader.GetString("CNH"),
                                Balance = (float)reader.GetDecimal("Balance"),
                                BirtyDay = reader.GetDateTime("Date_of_birth")
                            };
                        }
                        return null;
                    } catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message, "MESSAGE DE DEBUG");
                        return null;
                    }
                }
            }
        }

        public bool Delete(int id)
        {
            using (SqlConnection conn = new(_connectionString))
            {
                using (SqlCommand cmd = new(delete, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        conn.Open();

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Errro: " + ex.Message, "MESSAGE DE DEBUG");
                        return false;
                    }
                }
            }
        }
    }

    public class User
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required DateTime BirtyDay { get; set; }
        public required string CPF { get; set; }
        public required string CNH { get; set; }
        public float Balance { get; set; }
        public string? Password { get; set; } // Fazer mudaça para salvar a senha em hash, e não usar string
    }
}
