using Fucha.DataLayer.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class ValidateUsernameCommand : IRequest<bool>
    {
        public string Username { get; set; }
    }

    public class ValidateUsernameCommandHandler : IRequestHandler<ValidateUsernameCommand, bool>
    {
        private readonly IFuchaMilkteaContext _context;
        
        public ValidateUsernameCommandHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }

        public Task<bool> Handle(ValidateUsernameCommand command, CancellationToken cancellationToken)
        {
            bool userExists = _context.Users.Any(u => u.UserName == command.Username);
            return Task.FromResult(userExists);
        }
    }
}
