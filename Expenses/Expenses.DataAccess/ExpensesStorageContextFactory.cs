using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.DataAccess
{
    class ExpensesStorageContextFactory : IDesignTimeDbContextFactory<ExpensesStorageContext>
    {
        public ExpensesStorageContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ExpensesStorageContext>();
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=ExpensesStorage;Integrated Security=True");

            return new ExpensesStorageContext(optionsBuilder.Options);
        }
    
    }
}
