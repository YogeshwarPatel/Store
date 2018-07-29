﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Store.API.RequestModels;
using Store.API.Responses;
using Store.Core.BusinessLayer.Contracts;

namespace Store.API.Controllers
{

    [Route("api/v1/[controller]")]
    public class BranchController : Controller
    {
        protected ILogger Logger;
        protected IBranchService BranchBusinessObject;

        public BranchController(ILogger<BranchController> logger, IBranchService productionBusinessObject)
        {
            Logger = logger;
            BranchBusinessObject = productionBusinessObject;
        }

        protected override void Dispose(bool disposing)
        {
            BranchBusinessObject?.Dispose();

            base.Dispose(disposing);
        }

        [HttpGet("Branch")]
        public async Task<IActionResult> GetBranchsAsync(int? pageSize = 10, int? pageNumber = 1)
        {
            Logger?.LogDebug("{0} has been invoked", nameof(GetBranchsAsync));

            // Get response from business logic
            var response = await BranchBusinessObject.GetBranches((int)pageSize, (int)pageNumber);

            // Return as http response
            return response.ToHttpResponse();
        }


        [HttpGet("Branch/{BranchCode}")]
        public async Task<IActionResult> GetBranchByBranchCodeAsync(string BranchCode)
        {
            Logger?.LogDebug("{0} has been invoked", nameof(GetBranchByBranchCodeAsync));

            // Get response from business logic
            var response = await BranchBusinessObject.GetBranchByBranchCodeAsync(BranchCode);

            // Return as http response
            return response.ToHttpResponse();
        }
    }

}