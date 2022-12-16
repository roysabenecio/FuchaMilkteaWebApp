using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class EditSupplierCommand : IRequest<Supplier>
    {
        //public EditSupplierCommand(int id, SupplierDTO supplier)
        //{
        //    Id = id;
        //    Supplier = supplier;
        //}
        //public int Id { get; set; }
        //public SupplierDTO Supplier { get; set; }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? ContactNumber { get; set; }
        public bool IsRemoved { get; set; }
        public int UserId { get; set; }
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
            var selectedUser = _context.Users.FirstOrDefault(u => u.Id == request.UserId);
            var selectedSupplier = _context.Suppliers.FirstOrDefault(x => x.Id == request.Id);
            selectedSupplier.Name = request.Name;
            selectedSupplier.Address = request.Address;
            selectedSupplier.ContactNumber = request.ContactNumber;

            // Add activity
            var activityDescription = $"Edited Supplier {selectedSupplier.Name}";
            var newActivity = new ActivityHistory
            {
                User = selectedUser.FirstName + " " + selectedUser.LastName,
                Activity = activityDescription,
                Module = "Supplier",
                Date = DateTime.Now.ToString("MM/dd/yyyy HH:mm")
            };
            _context.ActivityHistories.Add(newActivity);
            _context.SaveChanges();

            return Task.FromResult(selectedSupplier);
        }
    }
}
