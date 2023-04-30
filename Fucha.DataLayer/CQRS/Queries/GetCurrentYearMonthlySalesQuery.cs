using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using Fucha.DomainClasses.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class GetCurrentYearMonthlySalesQuery: IRequest<List<MonthlySalesDTO>>
    {
        
    }

    public class GetCurrentYearMonthlySalesQueryHandler : IRequestHandler<GetCurrentYearMonthlySalesQuery, List<MonthlySalesDTO>>
    {
        private readonly IFuchaMilkteaContext _context;
        public GetCurrentYearMonthlySalesQueryHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }
        public Task<List<MonthlySalesDTO>> Handle(GetCurrentYearMonthlySalesQuery request, CancellationToken cancellationToken)
        {
            var transactionsThisYear = _context.SalesTransaction.Select(st => st).Where(st => st.DateSold.Year == DateTime.Now.Year).ToList();
            List<MonthlySalesDTO> monthlyTransactions = new List<MonthlySalesDTO>();
            for (int i = 1; i <= DateTime.Now.Month; i++)
            {
                var totalMonthSale = transactionsThisYear.Select(st => st).Where(st => st.DateSold.Month == i).Select(st => st.TotalSales).Sum();
                //monthlyTransactions = new MonthlySales
                //{
                //    Month = (Months)i,
                //    TotalSale = totalMonthSale,
                //};
                //monthlyTransactions.Add(new MonthlySales
                //(
                //    Month = (Months)i,
                //    TotalSale = totalMonthSale,
                //)
                //); 
                var currentMonth = (Months)i;
                monthlyTransactions.Add(new MonthlySalesDTO
                {
                    Month = currentMonth.ToString(),
                    TotalSale = totalMonthSale,
                });
            }

            return Task.FromResult(monthlyTransactions);
        }
    }
}

