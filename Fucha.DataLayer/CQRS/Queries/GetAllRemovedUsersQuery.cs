using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using MediatR;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class GetAllRemovedUsersQuery : IRequest<List<UserDisplayDTO>> { }
    public class GetAllRemovedUsersQueryHandler : IRequestHandler<GetAllRemovedUsersQuery, List<UserDisplayDTO>>
    {
        private readonly IFuchaMilkteaContext _context;
        public GetAllRemovedUsersQueryHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }

        public Task<List<UserDisplayDTO>> Handle(GetAllRemovedUsersQuery request, CancellationToken cancellationToken)
        {
            var allRemovedUsers = _context.Users.Select(u => u)
                .Where(u => u.IsRemoved == true)
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
            return Task.FromResult(allRemovedUsers);
        }
    }
}
