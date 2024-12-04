using Microsoft.Data.SqlClient;
using ProjetoDesenvolvimentoAplicacoesMultplataforma.Dao;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma.Services
{
    internal class TransactionService
    {
        private readonly string _connectionString = DotNetEnv.Env.GetString("Connection_String");

        private VehicleDao _daoVehicle = new();
        private UserDao _daoUser = new();
        private RentalHistoryDao _daoRentalHistory = new();

        public bool RentVehicle(
            int vehicleId,
            double rentalValue,
            int userId,
            DateTime rentalDate,
            DateTime rentalExpiration
        )
        {
            SqlTransaction transaction;
            RentalHistory rentalHistory = new()
            {
                VehicleId = vehicleId,
                UserId = userId,
                RentalDate = rentalDate,
                RentalExpiration = rentalExpiration,
                RentalValue = rentalValue
            };

            using SqlConnection conn = new(_connectionString);
            conn.Open();
            transaction = conn.BeginTransaction();

            try
            {
                _daoUser.UpdateBalance(transaction, conn, userId, rentalValue);
                _daoVehicle.UpdateRental(transaction, conn, vehicleId, userId, rentalDate, rentalExpiration);
                _daoRentalHistory.Save(transaction, conn, rentalHistory);

                transaction.Commit();
                return true;
            } catch
            {
                transaction.Rollback();
                return false;
            }
        }

        public double CancelRent(int vehicleId, double amountToBeRefunded)
        {
            Vehicle vehicle = _daoVehicle.Select(vehicleId);
            if (vehicle is null) throw new Exception("Veículo não encontrado");

            int userId = vehicle.RentedBy;

            SqlTransaction transaction;

            using SqlConnection conn = new(_connectionString);
            conn.Open();
            transaction = conn.BeginTransaction();

            try
            {
                _daoVehicle.CancelRent(transaction, conn, vehicleId);
                _daoUser.UpdateBalance(transaction, conn, vehicle.RentedBy, (amountToBeRefunded * -1));
                _daoRentalHistory.UpdateRentalExpiration(transaction, conn, userId, DateTime.Now.Date);
                transaction.Commit();
                return amountToBeRefunded;
            }
            catch
            {
                transaction.Rollback();
                return -1;
            }
        }
    }
}
