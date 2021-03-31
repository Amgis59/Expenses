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
    public class AccountController : ControllerBase
    {
        private readonly IRepository<Account> accountRepository;

        public AccountController(IRepository<Account> accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        [HttpGet]
        public IEnumerable<Account> GetAllExpenses()
        {
            return this.accountRepository.GetAll();
        }

        [HttpGet]
        [Route("accountId")]
        public Account GetExpenseById(int accountId)
        {
            return this.accountRepository.GetById(accountId);
        }
    }
}
