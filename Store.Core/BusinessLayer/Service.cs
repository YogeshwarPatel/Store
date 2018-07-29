using Microsoft.Extensions.Logging;
using Store.Core.BusinessLayer.Contracts;
using Store.Core.DataLayer;
using Store.Core.DataLayer.Contracts;
using Store.Core.DataLayer.Repositories;

namespace Store.Core.BusinessLayer
{
    public abstract class Service : IService
    {
        protected ILogger Logger;
        protected IUserInfo UserInfo;
        protected bool Disposed;
        protected readonly StoreDbContext DbContext;
        protected readonly myProductDBContext myPDBContext;
        protected IHumanResourcesRepository m_humanResourcesRepository;
        protected IProductionRepository m_productionRepository;
        protected ISalesRepository m_salesRepository;
        protected IBranchRepository m_branchRepository;

        public Service(ILogger logger, IUserInfo userInfo, StoreDbContext dbContext, myProductDBContext myprodPDBContext)
        {
            Logger = logger;
            UserInfo = userInfo;
            DbContext = dbContext;
            myPDBContext = myprodPDBContext;
        }

        public void Dispose()
        {
            if (!Disposed)
            {
                DbContext?.Dispose();

                Disposed = true;
            }
        }

        protected IHumanResourcesRepository HumanResourcesRepository
            => m_humanResourcesRepository ?? (m_humanResourcesRepository = new HumanResourcesRepository(UserInfo, DbContext));

        protected IProductionRepository ProductionRepository
            => m_productionRepository ?? (m_productionRepository = new ProductionRepository(UserInfo, DbContext));

        protected ISalesRepository SalesRepository
            => m_salesRepository ?? (m_salesRepository = new SalesRepository(UserInfo, DbContext));

        protected IBranchRepository branchRepository
            => m_branchRepository ?? (m_branchRepository = new BranchRepository(UserInfo, myPDBContext));
    }
}
