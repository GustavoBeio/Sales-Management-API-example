using Sales.Domain.Interfaces.Repositories;
using Sales.Domain.Interfaces.Repositories.DataConnector;

namespace Sales.Infra.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private IClientRepository? _clientRepository;
        public IClientRepository ClientRepository => _clientRepository ??= new ClientRepository(DbConnector);

        public IEmployeeRepository EmployeeRepository => throw new NotImplementedException();

        public IProductOrderRepository ProductOrderRepository => throw new NotImplementedException();

        public IProductRepository ProductRepository => throw new NotImplementedException();

        public IDbConnector DbConnector => throw new NotImplementedException();

        public void BeginTransaction()
        {
            DbConnector.DbTransaction = DbConnector.DbConnection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
        }

        public void CommitTransaction()
        {
            if(DbConnector.DbConnection.State == System.Data.ConnectionState.Open)
            {
                DbConnector?.DbTransaction?.Commit();
            }
        }

        public void RollbackTransaction()
        {
            if (DbConnector.DbConnection.State == System.Data.ConnectionState.Open)
            {
                DbConnector?.DbTransaction?.Commit();
            }
        }
    }
}
