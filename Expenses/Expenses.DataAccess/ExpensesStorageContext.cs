using Expenses.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.DataAccess
{
    public class ExpensesStorageContext : DbContext
    {
        public ExpensesStorageContext(DbContextOptions<ExpensesStorageContext> opt) : base(opt)
        {

        }
        public DbSet<Account> Accounts { get; set; }
    }
}
