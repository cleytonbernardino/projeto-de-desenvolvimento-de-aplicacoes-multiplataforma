using ProjetoDesenvolvimentoAplicacoesMultplataforma.Dao;
using ProjetoDesenvolvimentoAplicacoesMultplataforma.Utils;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma.Services
{
    internal class UserService
    {
        private readonly UserDao _dao = new();
        private readonly ViolationDao _daoPenalty = new();

        public int Save(
            int id,
            string firstName,
            string lastName,
            string email,
            string cpf,
            string cnh,
            double balance,
            DateTime birtyDay,
            List<Violation> violations,
            List<int> violationsToBeRemoved
        )
        {
            if (violations.Count > 0) balance = GetNewBalance(balance, violations);

            User user = new()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                BirtyDay = birtyDay,
                CPF = cpf,
                CNH = cnh,
                Balance = balance,
            };
            if (id == 0)
            {
                string cpfOnlyDigits = cpfUtils.ToCpf(cpf);
                if (!cpfUtils.IsCpfValid(cpfOnlyDigits)) return -2;
                user.CPF = cpfOnlyDigits;
                return _dao.Save(user);
            }

            SaveViolations(
                violations, violationsToBeRemoved
            );
            _dao.Update(user);
            return 0;
        }

        public DataTable ListUsers()
        {
            return _dao.ListUsers();
        }

        // Talvez remover essa opção e deixar somente cpf
        public User GetUserById(int id)
        {
            SqlParameter[] param =
            [
                new SqlParameter("@id", id)
            ];
            return _dao.Select("id=@id", param);
        }

        public User GetUserByCpf(string cpf)
        {
            SqlParameter[] param = [
                new SqlParameter("@cpf", cpf)
            ];
            return _dao.Select("cpf=@cpf", param);
        }

        public DataTable GetUsersByName(string name)
        {
            return _dao.Search(name);
        }

        public List<Violation> GetPenaltysByOwnerId(int ownerId)
        {
            return _daoPenalty.Select(ownerId);
        }

        public bool Delete(int id)
        {
            return _dao.Delete(id);
        }

        public double GetUserBalance(int id)
        {
            SqlParameter[] param =
            [
                new SqlParameter("@id", id)
            ];
            User user = _dao.Select("id=@id", param);
            return user.Balance;
        }

        private double GetNewBalance(double balance, List<Violation> violations)
        {
            foreach (Violation violation in violations)
            {
                if (violation.Id != 0) continue;
                balance -= violation.Cost;
            }
            return balance;
        }

        private void SaveViolations(
                List<Violation> violations,
                List<int> violationsToBeRemoved
            )
            {
                List<Violation> violationsToBeAdded = new();
                List<Violation> violationsToBeUpdated = new();
                if (violations.Count > 0)
                {
                    foreach (Violation violation in violations)
                    {
                        if (violation.Id != 0)
                        {
                            violationsToBeUpdated.Add(violation);
                            continue;
                        };
                        violationsToBeAdded.Add(violation);
                    }
                };
                if (violationsToBeAdded.Count > 0) _daoPenalty.Save(violationsToBeAdded);
                if (violationsToBeUpdated.Count > 0) _daoPenalty.Update(violationsToBeUpdated);
                if (violationsToBeRemoved.Count > 0) _daoPenalty.Delete(violationsToBeRemoved);
            }
        }
}
