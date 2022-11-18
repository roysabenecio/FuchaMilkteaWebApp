using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class RemoveSupplierCommand : IRequest<Supplier>
    {
        public int Id { get; set; }
    }

    public class RemoveSupplierCommandHandler : IRequestHandler<RemoveSupplierCommand, Supplier>
    {
        private readonly IFuchaMilkteaContext _context;
        public RemoveSupplierCommandHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }
        public Task<Supplier> Handle(RemoveSupplierCommand request, CancellationToken cancellationToken)
        {
            var selectedSupplier = _context.Suppliers.FirstOrDefault(supplier => supplier.Id == request.Id);   
            _context.Suppliers.Remove(selectedSupplier);
            _context.SaveChanges();
            return Task.FromResult(selectedSupplier);
        }
    }
}
