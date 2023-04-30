using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class AddSupplierCommand : IRequest<Supplier>
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? ContactPerson { get; set; }
        public string? ContactNumber { get; set; }
        public string? Email { get; set; }
        public int UserId { get; set; }
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
            var selectedUser = _context.Users.FirstOrDefault(u => u.Id == request.UserId);
            var newSupplier = new Supplier
            {
                Name = request.Name,
                Address = request.Address,
                ContactPerson = request.ContactPerson,
                ContactNumber = request.ContactNumber,
                Email = request.Email,
                DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy")
            };
            _context.Suppliers.Add(newSupplier);

            // Add activity
            var activityDescription = $"Added new supplier {newSupplier.Name}";
            var newActivity = new ActivityHistory
            {
                User = selectedUser.FirstName + " " + selectedUser.LastName,
                Activity = activityDescription,
                Module = "Supplier",
                Date = DateTime.Now.ToString("MM/dd/yyyy HH:mm")
            };
            _context.ActivityHistories.Add(newActivity);
            _context.SaveChanges();
            return Task.FromResult(newSupplier);
        }
    }
}
