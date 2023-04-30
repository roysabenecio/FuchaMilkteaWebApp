using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using MediatR;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class GetAllExistingUsersQuery : IRequest<List<UserDisplayDTO>> { }
    public class GetAllExistingUsersQueryHandler : IRequestHandler<GetAllExistingUsersQuery, List<UserDisplayDTO>>
    {
        private readonly IFuchaMilkteaContext _context;
        public GetAllExistingUsersQueryHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }

        public Task<List<UserDisplayDTO>> Handle(GetAllExistingUsersQuery request, CancellationToken cancellationToken)
        {
            var allExistingUsers = _context.Users.Select(u => u)
                .Where(u => u.IsRemoved == false)
                .Select(user => new UserDisplayDTO
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    UserName = user.UserName,
                    Role = user.Role,
                    UserStatus = user.UserStatus,
                    DateCreated = user.DateCreated,
                    IsRemoved = user.IsRemoved
                }).OrderByDescending(u => u.Id).ToList();
            return Task.FromResult(allExistingUsers);
        }
    }
}
