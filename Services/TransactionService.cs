using Microsoft.Data.SqlClient;
using ProjetoDesenvolvimentoAplicacoesMultplataforma.Dao;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma.Services
{
    internal class TransactionService
    {
        private readonly string _connectionString = DotNetEnv.Env.GetString("Connection_String");

        private VehicleDao _daoVehicle = new();
        private UserDao _daoUser = new();

        public bool RentVehicle(
            string licensePlate,
            double rentalValue,
            int userId,
            //DateTime rentalDate,
            DateTime rentalExpiration
        )
        {
            if (licensePlate.Length != 7) throw new Exception("Placa incorreta");
            SqlTransaction transaction;

            using SqlConnection conn = new(_connectionString);
            conn.Open();
            transaction = conn.BeginTransaction();

            try
            {
                _daoUser.UpdateBalance(transaction, conn, userId, rentalValue);
                _daoVehicle.UpdateRental(transaction, conn, licensePlate, userId, rentalExpiration);

                transaction.Commit();
                return true;
            } catch (Exception e)
            {
                MessageBox.Show("Erro ao alugar veículo: " + e.Message, "MESSAGEM DE DEBUG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                transaction.Rollback();
                return false;
            }
        }

        public double CancelRent(int vehicleId)
        {
            Vehicle vehicle = _daoVehicle.Select(vehicleId);
            if (vehicle is null) throw new Exception("Veículo não encontrado");

            double remainingValue = vehicle.DailyVehicleRate * (vehicle.RentalExpiration - DateTime.Now).Days;
            int userId = vehicle.RentedBy;

            SqlTransaction transaction;

            using SqlConnection conn = new(_connectionString);
            conn.Open();
            transaction = conn.BeginTransaction();

            try
            {
                _daoVehicle.CancelRent(transaction, conn, vehicleId);
                _daoUser.UpdateBalance(transaction, conn, vehicle.RentedBy, (remainingValue * -1));

                transaction.Commit();
                return remainingValue;
            }
            catch
            {
                transaction.Rollback();
                return -1;
            }
        }
    }
}
