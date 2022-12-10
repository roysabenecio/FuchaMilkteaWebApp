using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class RemoveSupplierCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }

    public class RemoveSupplierCommandHandler : IRequestHandler<RemoveSupplierCommand, bool>
    {
        private readonly IFuchaMilkteaContext _context;
        public RemoveSupplierCommandHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }
        public Task<bool> Handle(RemoveSupplierCommand request, CancellationToken cancellationToken)
        {
            var selectedSupplier = _context.Suppliers.FirstOrDefault(supplier => supplier.Id == request.Id);
            selectedSupplier.IsRemoved = true;
            _context.SaveChanges();
            return Task.FromResult(true);
        }
    }
}
