using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.DataAccess.Entities
{
    public class Aim : EntityBase
    {
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public double Value { get; set; }

    }
}
