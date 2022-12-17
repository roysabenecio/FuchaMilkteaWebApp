using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class RemoveUserCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
    }

    public class RemoveUserCommmandHandler : IRequestHandler<RemoveUserCommand, bool>
    {
        private readonly IFuchaMilkteaContext _context;
        public RemoveUserCommmandHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }
        public Task<bool> Handle(RemoveUserCommand request, CancellationToken cancellationToken)
        {
            var selectedUser = _context.Users.FirstOrDefault(user => user.Id == request.Id);
            selectedUser.IsRemoved = true;
            if (request.Id == 1)
            {
                return Task.FromResult(false);
            }
            if (request.Id == selectedUser.Id)
            {
                return Task.FromResult(false);
            }

            var actor = _context.Users.FirstOrDefault(x => x.Id == request.UserId);

            // Add activity
            var fullName = selectedUser.FirstName + " " + selectedUser.LastName;
            var activityDescription = $"Removed user {fullName}";
            var newActivity = new ActivityHistory
            {
                User = actor.FirstName + " " + actor.LastName,
                Activity = activityDescription,
                Module = "User",
                Date = DateTime.Now.ToString("MM/dd/yyyy HH:mm")
            };
            _context.ActivityHistories.Add(newActivity);
            _context.SaveChanges();
            return Task.FromResult(selectedUser.IsRemoved);
        }
    }

}