using Expenses.ApplicationServices.API.Domain;
using Expenses.ApplicationServices.API.Domain.Models;
using Expenses.DataAccess;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Expenses.ApplicationServices.API.Handlers
{
    public class GetExpensesHandler : IRequestHandler<GetExpensesRequest, GetExpensesResponse>
    {
        private readonly IRepository<DataAccess.Entities.Expense> expenseRepository;

        public GetExpensesHandler(IRepository<DataAccess.Entities.Expense> expenseRepository)
        {
            this.expenseRepository = expenseRepository;
        }

        public Task<GetExpensesResponse> Handle(GetExpensesRequest request, CancellationToken cancellationToken)
        {
            var expenses = this.expenseRepository.GetAll();
            var domainExpenses = new List<Domain.Models.Expense>();
            foreach (var expense in expenses)
            {
                domainExpenses.Add(new Domain.Models.Expense()
                {
                    Id = expense.Id,
                    Date = expense.Date
                });
                //foreach is the same as LINQ commented below
            }
            //var domainExpenses = expenses.Select(x => new Domain.Models.Expense()
            //{
            //    Id = x.Id,
            //    Date = x.Date
            //});
            var response = new GetExpensesResponse()
            {
                Data = domainExpenses.ToList()
            };
            return Task.FromResult(response);
        }
    }
}//25:29 - tydzień 4, lekcja 12
