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
            DateTime birtyDay,
            List<ViolationDao.Penalty> penaltiesToBeAdded,
            List<int> penaltiesToBeRemoved
        )
        {
            User user = new()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                BirtyDay = birtyDay,
                CPF = cpf,
                CNH = cnh,
                Balance = 0
            };
            if (id == 0)
            {
                string cpfOnlyDigits = cpfUtils.ToCpf(cpf);
                if (!cpfUtils.IsCpfValid(cpfOnlyDigits)) return -2;
                user.CPF = cpfOnlyDigits;
                return _dao.Save(user);
            }

            SavePenalty(
                penaltiesToBeAdded, penaltiesToBeRemoved
            );
            _dao.Update(user);
            return 0;
        }

        public DataTable ListUsers()
        {
            return _dao.ListUsers();
        }

        public User GetUserById(int id)
        {
            return _dao.Select(id);
        }

        public DataTable GetUsersByName(string name)
        {
            return _dao.Search(name);
        }

        public List<ViolationDao.Penalty> GetPenaltysByOwnerId(int ownerId)
        {
            return _daoPenalty.Select(ownerId);
        }

        public bool Delete(int id)
        {
            return _dao.Delete(id);
        }

        private void SavePenalty(
            List<ViolationDao.Penalty> violations,
            List<int> violationsToBeRemoved
        )
        {
            List<ViolationDao.Penalty> violationsToBeAdded = new();
            List<ViolationDao.Penalty> violationsToBeUpdated = new();
            if (violations.Count > 0)
            {
                foreach (ViolationDao.Penalty violation in violations)
                {
                    if (violation.Id != 0) {
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
