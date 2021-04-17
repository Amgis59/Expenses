using Expenses.DataAccess;
using Expenses.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expenses.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IncomesController : ControllerBase
    {
        private readonly IRepository<Income> incomesRepository;
        public IncomesController(IRepository<Income> incomesRepository)
        {
            this.incomesRepository = incomesRepository;
        }

        [HttpGet]
        public IEnumerable<Income> GetAllIncomes() => this.incomesRepository.GetAll();
        // or
        // {
        //      return this.incomesRepository.GetAll();
        // }

        [HttpGet]
        [Route("{incomeId}")]
        public Income GetIncomeById(int incomeId)
        {
            return this.incomesRepository.GetById(incomeId);
        }
    }
}
