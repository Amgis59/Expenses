using Expenses.ApplicationServices.API.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expenses.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpensesController : ControllerBase
    {
        private readonly IMediator mediator;
        public ExpensesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("accountId")]
        public async Task<IActionResult> GetAllExpenses ([FromQuery] GetExpensesRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }
    }
}
