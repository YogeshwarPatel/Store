using Microsoft.EntityFrameworkCore;
using Store.Common;
using Store.Core;
using Store.Core.BusinessLayer;
using Store.Core.BusinessLayer.Contracts;
using Store.Core.DataLayer;

namespace Store.API.UnitTests
{
    public static class ServiceMocker
    {
        private static string ConnectionString
            => "server=(local);database=Store;integrated security=yes;MultipleActiveResultSets=True;";

        private static string myProductConnectionString
            => "server=coa-darc-sql05\\dev_erp;database=integration;integrated security=yes;MultipleActiveResultSets=True;";

        public static IHumanResourcesService GetHumanResourcesService()
        {
            var options = new DbContextOptionsBuilder<StoreDbContext>()
                .UseSqlServer(ConnectionString)
                .Options;

            var myPoptions = new DbContextOptionsBuilder<myProductDBContext>()
                .UseSqlServer(myProductConnectionString)
                .Options;

            return new HumanResourcesService(LogHelper.GetLogger<HumanResourcesService>(), new UserInfo { Name = "qa" }, new StoreDbContext(options), new myProductDBContext(myPoptions));
        }

        public static IProductionService GetProductionService()
        {
            var options = new DbContextOptionsBuilder<StoreDbContext>()
                .UseSqlServer(ConnectionString)
                .Options;

            var myPoptions = new DbContextOptionsBuilder<myProductDBContext>()
                .UseSqlServer(myProductConnectionString)
                .Options;

            return new ProductionService(LogHelper.GetLogger<ProductionService>(), new UserInfo { Name = "qa" }, new StoreDbContext(options), new myProductDBContext(myPoptions));
        }

        public static ISalesService GetSalesService()
        {
            var options = new DbContextOptionsBuilder<StoreDbContext>()
                .UseSqlServer(ConnectionString)
                .Options;

            var myPoptions = new DbContextOptionsBuilder<myProductDBContext>()
                .UseSqlServer(myProductConnectionString)
                .Options;

            return new SalesService(LogHelper.GetLogger<SalesService>(), new UserInfo { Name = "qa" }, new StoreDbContext(options), new myProductDBContext(myPoptions));
        }


        public static IBranchService GetBranchService()
        {
            var options = new DbContextOptionsBuilder<StoreDbContext>()
                .UseSqlServer(ConnectionString)
                .Options;

            var myPoptions = new DbContextOptionsBuilder<myProductDBContext>()
           .UseSqlServer(myProductConnectionString)
           .Options;

            return new BranchService(LogHelper.GetLogger<BranchService>(), new UserInfo { Name = "mocker" }, new StoreDbContext(options), new myProductDBContext(myPoptions));
        }
    }
}
