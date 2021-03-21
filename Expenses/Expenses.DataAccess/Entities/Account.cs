using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.DataAccess.Entities
{
    public class Account : EntityBase
    {
        public double Balance { get; set; }

        public List<Expense> Expenses { get; set; }
        public List<Income> Incomes { get; set; }
        public Aim Aim { get; set; }
    }
}
