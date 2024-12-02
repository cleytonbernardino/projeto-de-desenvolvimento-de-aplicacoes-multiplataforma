using ProjetoDesenvolvimentoAplicacoesMultplataforma.Dao;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma.Services
{
    internal class VehicleService
    {
        private readonly VehicleDao _dao = new();

        public VehicleService()
        {
            CheckOverdueRent();
        }

        private void CheckOverdueRent()
        {
            try
            {
                _dao.DeleteOverdueRent();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao verificar alugueis vencidos", ex);
            }
        }

        // Colocar filtros
        public List<Vehicle> GetAllVehicles() => _dao.ListVehicle();

        public Vehicle? GetVehicleById(int id)
        {
            if (id < 0) return null;
            return _dao.Select(id);
        }

        public List<Vehicle> GetVehiclesByPlate(string licensePlate) => _dao.Search(licensePlate);

        public int Save(Vehicle vehicle) => _dao.Save(vehicle);

        public bool DeleteVehicleById(int id)
        {
            return _dao.Delete(id);
        }

        public double CalculateRent(int days, int vehicleId)
        {
            Vehicle vehicle = _dao.Select(vehicleId);
            if (vehicle is null) throw new Exception("Veículo não encontrado");
            return vehicle.DailyVehicleRate * days;
        }
    }
}
