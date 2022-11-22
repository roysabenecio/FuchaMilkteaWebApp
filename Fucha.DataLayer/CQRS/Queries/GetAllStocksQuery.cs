using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;

using Fucha.DomainClasses;
using Fucha.DomainClasses.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class GetAllStocksQuery : IRequest<List<StockDTO>>
    {
    }

    public class GetAllStocksQueryHandler : IRequestHandler<GetAllStocksQuery, List<StockDTO>>
    {
        private readonly IFuchaMilkteaContext _context;
        public GetAllStocksQueryHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }

        public Task<List<StockDTO>> Handle(GetAllStocksQuery request, CancellationToken cancellationToken)
        {
            //var allItems = _context.Stocks.Select(item => new Stock
            //{
            //    Id = item.Id,
            //    Name = item.Name,
            //    Measure = item.Measure,
            //    MeasurementUnit = item.MeasurementUnit,
            //    StockCategory = item.StockCategory
            //}).ToList();
            //return Task.FromResult<List<Stock>>(allItems);
            var allStocks = _context.Stocks.Select(x => x).ToList();
            var allSuppliers = _context.Suppliers.Select(x => x).ToList();
            var stockDTO = allStocks
                                      .Join(
                                        allSuppliers,
                                      stock => stock.SupplierId,
                                      supplier => supplier.Id,
                                      (stock, supplier) => new
                                      {
                                          stock.Id,
                                          //stock.Name,
                                          stock.Measure,
                                          MeasurementUnit = ((MeasurementUnit)stock.MeasurementUnit).ToString(),
                                          StockCategory = ((StockCategory)stock.StockCategory).ToString(),
                                          Supplier = supplier.Name
                                      }).ToList();
            //var getSupplierNameById = (id) => joinedStockSupplier.FirstOrDefault(s => s.SupplierId == id);


            var allStocksDTO = stockDTO.Select(stock => new StockDTO
            {
                Id = stock.Id,
                //Name = stock.Name,
                Measure = stock.Measure,
                MeasurementUnit = stock.MeasurementUnit,
                StockCategory = stock.StockCategory,
                Supplier = stock.Supplier
            }).ToList();

            //var allStockss = _context.Stocks.Select(stock => new StockDTO
            //{
            //    Id = stock.Id,
            //    Name = stock.Name,
            //    Measure = stock.Measure,
            //    //MeasurementUnit = Enum.GetName(typeof(MeasurementUnit), MeasurementUnit.Kilogram,
            //    //MeasurementUnit = (MeasurementUnit)Enum.ToObject(typeof(MeasurementUnit), stock.MeasurementUnit),
            //    MeasurementUnit = ((MeasurementUnit)stock.MeasurementUnit).ToString(),
            //    //StockCategory = (StockCategory)Enum.ToObject(typeof(StockCategory),stock.StockCategory)
            //    StockCategory = ((StockCategory)stock.StockCategory).ToString(),
            //    //StockCategory = (StockCategory)Enum.Parse(typeof(StockCategory),stock.StockCategory)
            //    //StockCategory = Enum.Parse(typeof(StockCategory),stock.StockCategory)

            //}).ToList();
            return Task.FromResult<List<StockDTO>>(allStocksDTO);
        }
    }
}
