using Fucha.DataLayer.Models;
using MediatR;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class RestoreSupplierCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }

    public class RestoreSupplierCommandHandler : IRequestHandler<RestoreSupplierCommand, bool>
    {
        private readonly IFuchaMilkteaContext _context;
        public RestoreSupplierCommandHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }
        public Task<bool> Handle(RestoreSupplierCommand request, CancellationToken cancellationToken)
        {
            var selectedSupplier = _context.Suppliers.FirstOrDefault(supplier => supplier.Id == request.Id);
            selectedSupplier.IsRemoved = false;
            _context.SaveChanges();
            return Task.FromResult(true);
        }
    }
}
