using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class AddSupplierCommand : IRequest<Supplier>
    {
        public string Name { get; set; }
        public string? Address { get; set; }
        public long ContactNumber { get; set; }
    }

    public class AddSupplierCommandHandler : IRequestHandler<AddSupplierCommand, Supplier>
    {
        private readonly IFuchaMilkteaContext _context;
        public AddSupplierCommandHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }
        public Task<Supplier> Handle(AddSupplierCommand request, CancellationToken cancellationToken)
        {
            var newSupplier = new Supplier { 
                Name = request.Name,
                Address = request.Address,
                ContactNumber = request.ContactNumber,
                DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy")
            };
            _context.Suppliers.Add(newSupplier);
            _context.SaveChanges();
            return Task.FromResult(newSupplier);
        }
    }
}
