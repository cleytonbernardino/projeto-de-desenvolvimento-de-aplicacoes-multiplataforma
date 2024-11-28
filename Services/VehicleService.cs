using ProjetoDesenvolvimentoAplicacoesMultplataforma.Dao;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma.Services
{
    internal class VehicleService
    {
        private readonly VehicleDao _dao = new();

        // Colocar filtros
        public List<Vehicle> GetAllVehicles()
        {
            return _dao.Listar();
        }

        public Vehicle? GetVehicleById(int id)
        {
            if (id < 0) return null;
            return _dao.Select(id);
        }

        public List<Vehicle> GetVehiclesByPlate(string licensePlate)
        {
            return _dao.Search(licensePlate);
        }

        public int Save(Vehicle vehicle)
        {
            return _dao.Save(vehicle);
        }

        public bool DeleteVehicleById(int id)
        {
            return _dao.Delete(id);
        }
    }
}
