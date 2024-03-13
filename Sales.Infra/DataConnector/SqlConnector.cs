using Sales.Domain.Interfaces.Repositories.DataConnector;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Sales.Infra.DataConnector
{
    public class SqlConnector : IDbConnector
    {
        public SqlConnector(string connectionString) 
        {
            DbConnection = SqlClientFactory.Instance.CreateConnection();
            DbConnection.ConnectionString = connectionString;
        }
        public IDbConnection DbConnection { get; }
        public IDbTransaction? DbTransaction { get; set; }


        public void Dispose()
        {
            DbConnection?.Dispose();
            DbTransaction?.Dispose();
        }
    }
}
