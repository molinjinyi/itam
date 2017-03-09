using Itam.Core.Collections;
using Itam.Core.Domain.Assets;
using Itam.Service.Assets.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Itam.Service.Assets
{
    public interface IComputerHostService
    {
        Task InsertComputerHostAsync(ComputerHost computerHost);

        Task DeleteComputerHostAsync(long id);


        Task UpdateComputerHostAsync(ComputerHost computerHost);


        Task<ComputerHost> GetComputerHostByIdAsync(long id);


        Task<IPageOfItems<ComputerHost>> GetList(int page,int pageSize,string keyword="", ComputerHostOrderBy computerHostOrderBy= ComputerHostOrderBy.IdDesc);
    }
}
