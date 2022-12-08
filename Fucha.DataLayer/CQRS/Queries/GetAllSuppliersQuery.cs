using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class GetAllSuppliersQuery : IRequest<List<Supplier>>
    {
    }

    public class GetAllSuppliersQueryHandler : IRequestHandler<GetAllSuppliersQuery, List<Supplier>>
    {
        private readonly IFuchaMilkteaContext _context;
        public GetAllSuppliersQueryHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }

        public Task<List<Supplier>> Handle(GetAllSuppliersQuery request, CancellationToken cancellationToken)
        {
            //    var allSuppliers = _context.Suppliers.Select(supplier => new Supplier
            //    {
            //        Id = supplier.Id,
            //        Name = supplier.Name,
            //        Address = supplier.Address,
            //        ContactNumber = supplier.ContactNumber,
            //        DateAdded = supplier.DateAdded,
            //        IsRemoved = supplier.IsRemoved,
            //    }).ToList();
            var allSuppliers = _context.Suppliers.Select(supplier => supplier).ToList();
            return Task.FromResult(allSuppliers);
        }
    }
}
