using Itam.Core.Data;
using Itam.Core.Domain.Assets;
using Itam.Service.Assets;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Itam.Service.Tests
{
    public class ComputerHost_UnitTest1
    {
        [Fact]
        public async Task InsertComputerHostAsync_Test()
        {
            var computerHostService = new ComputerHostService(new MySqlDatabase());
            await computerHostService.InsertComputerHostAsync(new ComputerHost
            {
                Id = 1,
                UpdatedOn = DateTime.Now
            });
        }
    }
}
