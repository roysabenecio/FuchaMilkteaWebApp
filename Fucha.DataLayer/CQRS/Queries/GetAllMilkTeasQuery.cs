using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class GetAllMilkTeasQuery : IRequest<List<MilkTeaDTO>>
    {

    }

    public class GetAllMilkTeasQueryHandler : IRequestHandler<GetAllMilkTeasQuery, List<MilkTeaDTO>>
    {
        private readonly IFuchaMilkteaContext _dbContext;

        public GetAllMilkTeasQueryHandler(IFuchaMilkteaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<MilkTeaDTO>> Handle(GetAllMilkTeasQuery request, CancellationToken cancellationToken)
        {
            var allMilkTeas = _dbContext.Recipes.Select(milktea => new MilkTeaDTO
            {
                Id = milktea.Id,
                Name = milktea.Name,
                Size = milktea.Size,
                //Price = milktea.Price
            }).ToList();
            return Task.FromResult<List<MilkTeaDTO>>(allMilkTeas);
        }
    }
}
