using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.DataAccess.Entities
{
    public class ExpenseCategory : EntityBase
    {
        public int ExpenseId { get; set; }
        public Expense Expense { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
