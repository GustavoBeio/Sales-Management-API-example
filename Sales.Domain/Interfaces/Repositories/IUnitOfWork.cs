using Sales.Domain.Interfaces.Repositories.DataConnector;

namespace Sales.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        IClientRepository ClientRepository { get; }
        IEmployeeRepository EmployeeRepository { get; }
        IProductOrderRepository ProductOrderRepository { get; }
        IProductRepository ProductRepository { get; }
        IDbConnector DbConnector { get; }

        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
    }
}
