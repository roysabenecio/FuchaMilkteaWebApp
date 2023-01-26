using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class RestoreSupplierCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
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
            var selectedUser = _context.Users.FirstOrDefault(u => u.Id == request.UserId);
            var selectedSupplier = _context.Suppliers.FirstOrDefault(supplier => supplier.Id == request.Id);
            selectedSupplier.IsRemoved = false;

            // Add activity
            var activityDescription = $"Restored supplier {selectedSupplier.Name}";
            var newActivity = new ActivityHistory
            {
                User = selectedUser.FirstName + " " + selectedUser.LastName,
                Activity = activityDescription,
                Module = "Supplier",
                Date = DateTime.Now.ToString("MM/dd/yyyy HH:mm")
            };
            _context.ActivityHistories.Add(newActivity);
            _context.SaveChanges();
            return Task.FromResult(true);
        }
    }
}
