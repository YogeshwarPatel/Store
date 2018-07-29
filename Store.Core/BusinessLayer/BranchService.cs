using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Store.Core.BusinessLayer.Contracts;
using Store.Core.BusinessLayer.Responses;
using Store.Core.DataLayer;
using Store.Core.EntityLayer.myProduct;
using Store.Core.DataLayer.Repositories;



namespace Store.Core.BusinessLayer
{
    public class BranchService : Service, IBranchService
    {
        public BranchService(ILogger<BranchService> logger, IUserInfo userInfo, StoreDbContext dbContext, myProductDBContext myPDBContext)
            : base(logger, userInfo, dbContext, myPDBContext)
        {
        }

        public Task<ISingleResponse<Branch>> GetBranchByBranchCodeAsync(string branchCode)
        {
            throw new NotImplementedException();
        }



        public async Task<IPagedResponse<Branch>> GetBranches(int pageSize = 10, int pageNumber = 1)
        {
            Logger?.LogInformation("{0} has been invoked", nameof(GetBranches));

            var response = new PagedResponse<Branch>();

            try
            {
                // Get query
                var query = branchRepository.GetBranches(pageSize, pageNumber);

                // Set information for paging
                response.PageSize = pageSize;
                response.PageNumber = pageNumber;
                response.ItemsCount = await query.CountAsync();
                // Retrieve items, set model for response
                response.Model = await query.Paging(pageSize, pageNumber).ToListAsync();
            }
            catch (Exception ex)
            {
                response.SetError(ex, Logger);
            }

            return response;
        }
    }
}


