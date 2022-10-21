//using Fucha.DataLayer.DTOs;
//using Fucha.DataLayer.Models;
//using MediatR;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Fucha.DataLayer.CQRS.Queries
//{
//    public class GetUserQuery : IRequest<UserDTO>
//    {
//        public string UserName { get; set; }
//        public string Password { get; set; }
//    }

//    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserDTO>
//    {
//        private readonly IFuchaMilkteaContext _dbContext;

//        public GetUserQueryHandler(IFuchaMilkteaContext dbContext)
//        {
//            _dbContext = dbContext;
//        }

//        public Task<UserDTO> Handle(GetUserQuery request, CancellationToken cancellationToken)
//        {
//            var response = _dbContext.Users.Select(user => (user.UserName == request.UserName) ? new UserDTO
//            {
//                Id = user.Id,
//                FirstName = user.FirstName,
//                LastName = user.LastName,
//                Email = user.Email,
//                UserName = user.UserName,
//                Role = user.Role
//            );
//            return Task.FromResult<UserDTO>(selectedUser);
//        }
//    }
//}
