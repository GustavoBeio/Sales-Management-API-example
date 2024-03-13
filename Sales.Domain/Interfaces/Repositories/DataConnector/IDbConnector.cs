using System.Data;

namespace Sales.Domain.Interfaces.Repositories.DataConnector
{
    public interface IDbConnector : IDisposable
    {
        IDbConnection DbConnection { get;}
        IDbTransaction? DbTransaction { get; set; }
    }
}
