using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Itam.Core.Collections;
using Itam.Core.Domain.Assets;
using Itam.Service.Assets.Models;
using Itam.Core.Data;
using Dapper;

namespace Itam.Service.Assets
{
    public class ComputerHostService : IComputerHostService
    {
        private readonly IDatabase _database;
        public ComputerHostService(IDatabase database)
        {
            _database = database;
        }
        public Task DeleteComputerHostAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<ComputerHost> GetComputerHostByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IPageOfItems<ComputerHost>> GetList(int page, int pageSize, string keyword = "", ComputerHostOrderBy computerHostOrderBy = ComputerHostOrderBy.IdDesc)
        {
            throw new NotImplementedException();
        }

        public async Task InsertComputerHostAsync(ComputerHost computerHost)
        {
            using (var conn = _database.GetClosedConnection())
            {
               await conn.ExecuteAsync("Insert Into `ComputerHost`(`Id`,`CreatedOn`,`UpdatedOn`) values(@Id,@CreatedOn,@UpdatedOn)", computerHost);
            }
        }

        public Task UpdateComputerHostAsync(ComputerHost computerHost)
        {
            throw new NotImplementedException();
        }
    }
}
