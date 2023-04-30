using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class GetDailySalesQuery: IRequest<DailySalesDTO>
    {
    }

    public class GetDailySalesQueryHandler: IRequestHandler<GetDailySalesQuery, DailySalesDTO>
    {
        private readonly IFuchaMilkteaContext _context;
        public GetDailySalesQueryHandler(IFuchaMilkteaContext context) 
        {
            _context = context;
        }

        public Task<DailySalesDTO> Handle(GetDailySalesQuery request, CancellationToken cancellationToken)
        {
            var dailySales = _context.SalesTransaction
                .Select(x => x)
                .Where(st => st.DateSold.Day == DateTime.Now.Day);
            var totalDailySales = dailySales.Select(x => x.TotalSales).Sum();
            var totalItemSold = dailySales.Select(x => x.ItemQuantity).Sum();
            
            DailySalesDTO dailySalesDTO = new DailySalesDTO()
            {
                DailySales = totalDailySales,
                ItemsSold = totalItemSold,
            };

            return Task.FromResult(dailySalesDTO);
        }
    }
}
