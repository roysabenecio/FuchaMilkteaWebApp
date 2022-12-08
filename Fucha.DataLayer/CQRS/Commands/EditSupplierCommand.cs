using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class EditSupplierCommand : IRequest<Supplier>
    {
        public EditSupplierCommand(int id, SupplierDTO supplier)
        {
            Id = id;
            Supplier = supplier;
        }
        public int Id { get; set; }
        public SupplierDTO Supplier { get; set; }
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
            selectedSupplier.Name = request.Supplier.Name;
            selectedSupplier.Address = request.Supplier.Address;
            selectedSupplier.ContactNumber = request.Supplier.ContactNumber;
            _context.SaveChanges();

            return Task.FromResult(selectedSupplier);
        }
    }
}
