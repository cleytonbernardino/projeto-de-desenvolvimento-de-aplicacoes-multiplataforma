using System.Data;
using Microsoft.Data.SqlClient;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma.Dao
{
    internal class UserDao
    {
        private readonly string _connectionString = DotNetEnv.Env.GetString("Connection_String");

        private const string _login = "SELECT ISNULL((SELECT Id FROM tbl_user WHERE Username = @Username AND Password = @Password), -1) AS UserId;";

        private const string _firstUse = @"
            INSERT INTO tbl_user
                ([First_name], [Last_name], [Email], [Balance], [Date_of_birth], [CPF], [CNH], [Role], [Username], [Password]) 
            VALUES 
                (@First_name, 'Seu sobrenome', 'seuEmail@example.com', 0.00, '2002-04-15', '11111111111', '222222222', 'Administrador', @Username, @Password);
            DELETE FROM tbl_user WHERE Id = 1;";

        private const string _insert = "INSERT INTO tbl_user (" +
            "First_name, Last_name, Email, Balance, Date_of_birth, CPF, CNH" +
            ") OUTPUT INSERTED.ID " + 
            "VALUES (@First_name, @Last_name, @Email, @Balance, @Date_of_birth, @CPF, @CNH);";

        private const string _update = "UPDATE tbl_user SET " +
            "First_name=@First_name, Last_name=@Last_name, Email=@Email, Balance=@Balance, Date_of_birth=@Date_of_birth" +
            " WHERE id=@id";

        private const string _updateBalance = "UPDATE tbl_user SET Balance= Balance - @valor WHERE id=@id";

        private const string _select = "SELECT * FROM tbl_user WHERE CPF=@CPF";

        private const string _search = "SELECT id, First_name as Nome, Last_name as Sobrenome, CPF FROM tbl_user " +
            "WHERE CONCAT(First_name, Last_name) LIKE @CompleteName;";

        private const string _list = "SELECT id, First_name as Nome, Last_name as Sobrenome, CPF FROM tbl_user;";

        private const string _delete = "DELETE FROM tbl_user WHERE id=@id;";

        public UserDao()
        {
            using (SqlConnection conn = new(_connectionString))
            {
                conn.Open();
                string comand = @"
                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbl_user' AND schema_id = SCHEMA_ID('dbo'))
                    BEGIN
                        CREATE TABLE [dbo].[tbl_user] (
                            [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                            [First_name]      VARCHAR(25)    NOT NULL,
                            [Last_name]       VARCHAR(50)    NOT NULL,
                            [Email]           VARCHAR(255)   UNIQUE NOT NULL,
                            [Balance]         DECIMAL(8, 2)  NOT NULL,
                            [Date_of_birth]   DATE           NOT NULL,
                            [CPF]             NCHAR(11)      UNIQUE NOT NULL,
                            [CNH]             NCHAR(9)       NOT NULL,
                            [Role]            VARCHAR(15)    NOT NULL DEFAULT ('usuário'),
                            [Username]        VARCHAR(30)    NOT NULL,
                            [Password]        VARCHAR(100)   NOT NULL
                        ); 
                        INSERT INTO [dbo].[tbl_user] 
                            ([First_name], [Last_name], [Email], [Balance], [Date_of_birth], [CPF], [CNH], [Role], [Username], [Password]) 
                        VALUES 
                            ('ME EXCLUA', 'CONTA INSEGURA', 'admin@example.com', 0.00, '2002-04-15', '00000000000', '000000000', 'Administrador', 'admin', 'admin');
                    END;";
                using (SqlCommand cmd = new SqlCommand(comand, conn))
                {
                    if (cmd.ExecuteNonQuery() > 0) MessageBox.Show(
                        "Esse é o primeiro uso do programa, foi criado um usuário chamado admin com senha admin, use para criar um novo, e APAGUE ESTE!!.",
                        "IMPORTANTE LEIA", MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
                }
            }
        }

        public int Login(string username, string password)
        {
            using SqlConnection conn = new(_connectionString);
            using SqlCommand cmd = new(_login, conn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            try
            {
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch
            {
                return -1;
            }
        }

        public int FirstUse(string firstName, string username, string password)
        {
            using SqlConnection conn = new(_connectionString);
            using SqlCommand cmd = new(_firstUse, conn);
            cmd.Parameters.AddWithValue("@First_name", firstName);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            conn.Open();
            cmd.ExecuteNonQuery();
            return 2;
        }

        public int Save(User user)
        {
            using (SqlConnection conn = new(_connectionString))
            {
                using (SqlCommand cmd = new(_insert, conn))
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
                using (SqlCommand cmd = new(_update, conn))
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

        public void UpdateBalance(SqlTransaction transaction, SqlConnection conn, int userId, double rentValue)
        {
            //double value = user.Balance - rentValue;
            using SqlCommand cmd = new(_updateBalance, conn, transaction);
            cmd.Parameters.AddWithValue("@valor", rentValue);
            cmd.Parameters.AddWithValue("@id", userId);
            try
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows == 0) throw new Exception("Erro ao atualizar saldo");
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message, "MESSAGE DE DEBUG| UpdateBalance(userDao)");
                throw new Exception("Erro ao atualizar saldo");
            }
        }

        public DataTable Search(string completeName)
        {
            DataTable dt = new();
            SqlDataAdapter da;
            using (SqlConnection conn = new(_connectionString))
            {
                using (SqlCommand cmd = new(_search, conn))
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
                using (SqlCommand cmd = new(_list, conn))
                {
                    da = new SqlDataAdapter(cmd);
                    conn.Open();
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public User? Select(string cpf)
        {
            using SqlConnection conn = new(_connectionString);
            using SqlCommand cmd = new(_select, conn);
            cmd.Parameters.AddWithValue("@CPF", cpf);
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
                        CPF = cpf,
                        CNH = reader.GetString("CNH"),
                        Balance = (float)reader.GetDecimal("Balance"),
                        BirtyDay = reader.GetDateTime("Date_of_birth"),
                        Role = reader.GetString("Role")
                    };
                }
                return null;
            } catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "MESSAGE DE DEBUG");
                return null;
            }
        }

        public User Select(int id)
        {
            using SqlConnection conn = new(_connectionString);
            using SqlCommand cmd = new("SELECT * FROM tbl_user WHERE id=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new User()
                    {
                        Id = id,
                        FirstName = reader.GetString("First_name"),
                        LastName = reader.GetString("Last_name"),
                        Email = reader.GetString("email"),
                        CPF = reader.GetString("CPF"),
                        CNH = reader.GetString("CNH"),
                        Balance = (float)reader.GetDecimal("Balance"),
                        BirtyDay = reader.GetDateTime("Date_of_birth"),
                        Role = reader.GetString("Role")
                    };
                }
                throw new Exception("Usuário não encontrado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "MESSAGE DE DEBUG");
                throw new Exception("Usuário não encontrado");
            }
        }

        public bool Delete(int id)
        {
            using (SqlConnection conn = new(_connectionString))
            {
                using (SqlCommand cmd = new(_delete, conn))
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
        private string _role = "Usuário";
        //private string _username = "";

        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required DateTime BirtyDay { get; set; }
        public required string CPF { get; set; }
        public required string CNH { get; set; }
        public double Balance { get; set; }
        public string Role {
            get => _role; set
            {
                if (value.Length > 15) throw new Exception("Cargo muito grande");
                _role = value;
            }
        }
        //public string Username 
        //{
        //    get => _username; set
        //    {
        //        if (value.Length > 30) throw new Exception("Nome de usuário muito grande");
        //        _username = value;
        //    }
        //}
        //public string Password { get; set; } = "";
    }
}
