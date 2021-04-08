using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.ApplicationServices.API.Domain
{
    public class GetExpensesRequest : IRequest<GetExpensesResponse>
    {
    }
}
