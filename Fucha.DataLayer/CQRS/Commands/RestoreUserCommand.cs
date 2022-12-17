﻿using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class RestoreUserCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
    }

    public class RestoreUserCommandHandler : IRequestHandler<RestoreUserCommand, bool>
    {
        private readonly IFuchaMilkteaContext _context;
        public RestoreUserCommandHandler(IFuchaMilkteaContext dbContext)
        {
            _context = dbContext;
        }
        public Task<bool> Handle(RestoreUserCommand request, CancellationToken cancellationToken)
        {
            var actor = _context.Users.FirstOrDefault(x => x.Id == request.UserId);

            var selectedUser = _context.Users.FirstOrDefault(user => user.Id == request.Id);
            selectedUser.IsRemoved = false;

            // Add activity
            var fullName = actor.FirstName + " " + actor.LastName;
            var activityDescription = $"Restored user {fullName}";
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
