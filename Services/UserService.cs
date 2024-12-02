using ProjetoDesenvolvimentoAplicacoesMultplataforma.Dao;
using ProjetoDesenvolvimentoAplicacoesMultplataforma.Utils;
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
            string role,
            string username,
            string password,
            DateTime birtyDay,
            List<Violation> violationsToBeAdd,
            List<Violation> violationsToBeUpdate,
            List<Violation> violationsToBeRemoved
        )
        {
            if (
                violationsToBeAdd .Count > 0|| violationsToBeUpdate.Count > 0 || violationsToBeRemoved.Count > 0
            ) balance = GetNewBalance(balance, violationsToBeAdd, violationsToBeUpdate);

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
                Role = role
            };
            if (id == 0)
            {
                string cpfOnlyDigits = cpfUtils.ToCpf(cpf);
                if (!cpfUtils.IsCpfValid(cpfOnlyDigits)) return -2;
                user.CPF = cpfOnlyDigits;
                return _dao.Save(user);
            }

            SaveViolations(
                violationsToBeAdd, violationsToBeUpdate, violationsToBeRemoved
            );
            _dao.Update(user);
            return 0;
        }

        public int Login (string username, string password) => _dao.Login(username, password);

        public int FirstUse(string firstName, string username, string password) => _dao.FirstUse(firstName, username, password);

        public DataTable ListUsers()
        {
            return _dao.ListUsers();
        }

        public User? GetUserById(int id) => _dao.Select(id);

        public User? GetUserByCpf(string cpf)
        {
            if (cpf.Length == 14) cpf = cpfUtils.ToCpf(cpf);
            return _dao.Select(cpf);
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

        public double GetUserBalance(string cpf)
        {
            if (cpf.Length == 14) cpf = cpfUtils.ToCpf(cpf);
            User user = _dao.Select(cpf);
            return user.Balance;
        }

        public string GetRole(int currentUserId, string newUserRole)
        {
            string role = GetUserById(currentUserId).Role;

            if (role == "Administrador") return newUserRole;
            else if (role == "Funcionário") return "Usuário";
            return "NA";
        }

        private double GetNewBalance(
            double balance, List<Violation> violationsToBeAdd, List<Violation> violationsToBeUpdate
        )
        {
            (List<Violation> Add, List<Violation> Edit) = (violationsToBeAdd, violationsToBeUpdate);
            foreach (Violation violation in Add)
            {
                balance -= violation.Cost;
            }
            foreach (Violation violation in Edit)
            {
                balance -= violation.Cost;
            }
            return balance;
        }

        private void SaveViolations(
            List<Violation> violationsToBeAdd,
            List<Violation> violationsToBeUpdate,
            List<Violation> violationsToBeRemoved
            )
        {
            if (violationsToBeAdd.Count > 0) _daoPenalty.Save(violationsToBeAdd);
            if (violationsToBeUpdate.Count > 0) _daoPenalty.Update(violationsToBeUpdate);
            if (violationsToBeRemoved.Count > 0) _daoPenalty.Delete(violationsToBeRemoved);
        }
    }
}
