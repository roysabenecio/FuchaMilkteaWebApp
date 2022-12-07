using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class EditSupplierCommand : IRequest<Supplier>
    {
        public int Id { get; set; }
        //public Supplier Supplier { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
    }

    public class EditSupplierCommandHandler : IRequestHandler<EditSupplierCommand, Supplier>
    {
        private readonly IFuchaMilkteaContext _context;
        public EditSupplierCommandHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }

        public Task<Supplier> Handle(EditSupplierCommand request, CancellationToken cancellationToken)
        {
            var selectedSupplier = _context.Suppliers.FirstOrDefault(x => x.Id == request.Id);
            selectedSupplier.Name = request.Name;
            selectedSupplier.Address = request.Address;
            selectedSupplier.ContactNumber = request.ContactNumber;
            _context.SaveChanges();

            return Task.FromResult(selectedSupplier);
        }
    }
}
