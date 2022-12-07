using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using MediatR;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class GetAllLoginCredentialsQuery : IRequest<List<LoginCredentialsDTO>>
    {
    }

    public class GetAllLoginCredentialsQueryHandler : IRequestHandler<GetAllLoginCredentialsQuery, List<LoginCredentialsDTO>>
    {
        private readonly IFuchaMilkteaContext _context;
        public GetAllLoginCredentialsQueryHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }

        public Task<List<LoginCredentialsDTO>> Handle(GetAllLoginCredentialsQuery request, CancellationToken cancellationToken)
        {
            var userCredentials = _context.Users.Select(u => new LoginCredentialsDTO
            {
                Id = u.Id,
                UserName = u.UserName,
                //Password = u.Password
            }).ToList();

            return Task.FromResult(userCredentials);
        }
    }

}
