using Dapper;
using Sales.Domain.Interfaces.Repositories;
using Sales.Domain.Interfaces.Repositories.DataConnector;
using Sales.Domain.Models;

namespace Sales.Infra.Repositories
{
    internal class ClientRepository(IDbConnector dbConnector) : IClientRepository
    {
        private readonly IDbConnector _dbConnector = dbConnector;

        public Task CreateAsync(ClientModel client)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string clientId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistsbyIdAsync(string clientId)
        {
            string sql = $"SELECT 1 FROM Client WHERE Id = @Id";
            if (string.IsNullOrWhiteSpace(clientId))
            {
                sql += "AND Id = @Id";
            }
            var clients = await _dbConnector.DbConnection.QueryAsync<bool>(sql, new { Id = clientId }, _dbConnector.DbTransaction);
            return clients.FirstOrDefault();
        }

        public Task<bool> ExistsbyNameAsync(string clientName)
        {
            throw new NotImplementedException();
        }

        public async Task<ClientModel> GetbyIdAsync(string clientId)
        {
            string sql = @"SELECT [Id]
                              ,[Name]
                              ,[Email]
                              ,[PhoneNumber]
                              ,[Adress]
                              ,[CreatedAt]
                           FROM [dbo].[Client]
                           WHERE 1 = 1";
            if (string.IsNullOrWhiteSpace(clientId))
            {
                sql += "AND Id = @Id";
            }
            var clients = await _dbConnector.DbConnection.QueryAsync<ClientModel>(sql, new { Id = clientId }, _dbConnector.DbTransaction);
            return (ClientModel)clients;
        }

        public async Task<List<ClientModel>> ListbyFilterAsync(string clientId, string name)
        {
            string sql = @"SELECT [Id]
                              ,[Name]
                              ,[Email]
                              ,[PhoneNumber]
                              ,[Adress]
                              ,[CreatedAt]
                           FROM [dbo].[Client]
                           WHERE 1 = 1";
            if (string.IsNullOrWhiteSpace(clientId))
            {
                sql += "AND Id = @Id";
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                sql += "AND Name like @Name";
            }
            var clients = await _dbConnector.DbConnection.QueryAsync<ClientModel>(sql, new { Id = clientId, Name = "%" + name + "%" }, _dbConnector.DbTransaction);
            return clients.ToList();
        }

        public Task UpdateAsync(ClientModel client)
        {
            throw new NotImplementedException();
        }
    }
}
