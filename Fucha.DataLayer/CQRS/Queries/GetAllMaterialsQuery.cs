//using Fucha.DataLayer.DTOs;
//using Fucha.DataLayer.Models;
//using Fucha.DomainClasses;
//using MediatR;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Fucha.DataLayer.CQRS.Queries
//{
//    public class GetAllMaterialsQuery : IRequest<List<Material>>
//    {
//    }

//    public class GetAllMaterialsQueryHandler : IRequestHandler<GetAllMaterialsQuery, List<Material>>
//    {
//        private readonly IFuchaMilkteaContext _dbContext;
//        public GetAllMaterialsQueryHandler(IFuchaMilkteaContext dbContext)
//        {
//            _dbContext = dbContext;
//        }

//        public Task<List<Material>> Handle(GetAllMaterialsQuery request, CancellationToken cancellationToken)
//        {
//            var allMaterials = _dbContext.Materials.Select(material => new Material
//            {
//                Id = material.Id,
//                Name = material.Name,
//                MaterialCategory = material.MaterialCategory,
//                Quantity = material.Quantity,
//                MeasurementType = material.MeasurementType,
//            }).ToList();
//            return Task.FromResult<List<Material>>(allMaterials);
//        }
//    }
//}
