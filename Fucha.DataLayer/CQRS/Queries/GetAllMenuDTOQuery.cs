using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using Fucha.DomainClasses.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class GetAllMenuDTOQuery : IRequest<List<MenuDTO>>
    {
    }

    public class GetAllMenuDTOQueryHandler : IRequestHandler<GetAllMenuDTOQuery, List<MenuDTO>>
    {
        private readonly IFuchaMilkteaContext _context;
        public GetAllMenuDTOQueryHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }
        public Task<List<MenuDTO>> Handle(GetAllMenuDTOQuery request, CancellationToken cancellationToken)
        {
            var getMenuCategory = _context.MenuCategories.Single(mc => mc.Id == 1);

            var allMenus = _context.Menus.Select(menu => new MenuDTO
            {
                Id = menu.Id,
                Name = menu.Name,
                //MenuCategory = (menu) => { var s = _context.MenuCategories.Single(mc => mc.Id == menu.MenuCategoryId); return s.Name; },
                //MenuCategory = _context.MenuCategories.Select(a => a.Name).Where(mc => mc.Contains("Classic Milk Tea")).Name,
                MenuCategory = _context.MenuCategories.Single(a => a.Id == menu.MenuCategoryId).Name

                //MenuCategory = menu.Men
                //}).DistinctBy(x => new { x.Id, x.Name, x.MenuCategory}).ToList();
                //}).Distinct(x => x.Name).ToList();
            }).ToList();

            var distinctMenu = allMenus.DistinctBy(x => x.Name).ToList();


            return Task.FromResult<List<MenuDTO>>(distinctMenu);
        }
    }
}
