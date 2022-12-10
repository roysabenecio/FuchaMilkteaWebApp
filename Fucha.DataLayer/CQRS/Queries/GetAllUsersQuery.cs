using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using MediatR;


namespace Fucha.DataLayer.CQRS.Queries
{
    public class GetAllUsersQuery : IRequest<List<UserDisplayDTO>> { }

    public class GetUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<UserDisplayDTO>>
    {
        private readonly IFuchaMilkteaContext _dbContext;

        public GetUsersQueryHandler(IFuchaMilkteaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<UserDisplayDTO>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var allUsers = _dbContext.Users.Select(user => new UserDisplayDTO
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Role = user.Role,
                UserStatus = user.UserStatus,
                DateCreated = user.DateCreated,
                IsRemoved = user.IsRemoved
            }).ToList();
            return Task.FromResult(allUsers);
        }
    }
}
