using System.Security.Claims;
using webtuyensinh.Models;

namespace webtuyensinh.Services
{
    public interface IMenuService
    {
        IEnumerable<MenuItemModel> GetMenuByGroupId(int id);
        bool rule(ClaimsPrincipal User, Enum md);
    }

    public class MenuService : IMenuService
    {
        public readonly WebtuyensinhDbContext _context;
        public MenuService(WebtuyensinhDbContext context) 
        {
            _context = context;
        }
        public IEnumerable<MenuItemModel> GetMenuByGroupId(int id) {
            return _context.MenuItemModel
                .Where(m => m.GroupID == id)
                .Where(m => m.ParentID == null)
                .Select(m => new MenuItemModel
                {
                    Id = m.Id,
                    GroupID = m.GroupID,
                    ParentID = m.ParentID,
                    Name = m.Name,
                    URL = m.URL,
                    Controller = m.Controller,
                    Action = m.Action,
                    DisplayCondition = m.DisplayCondition,
                    DisplayOrder = m.DisplayOrder,
                    Target = m.Target,
                    Status = m.Status,
                    Child = _context.MenuItemModel
                    .Where(m2 => m2.ParentID == m.Id)
                    .OrderBy(m2 => m2.DisplayOrder)
                    .ToList()
                })
                .OrderBy(m => m.DisplayOrder)
                .ToList();
        }

        public bool rule(ClaimsPrincipal User, Enum md)
        {
            switch (md)
            {
                case Conditions.NotAuthentication:
                    return !User.Identity.IsAuthenticated;
                case Conditions.Authentication:
                    return User.Identity.IsAuthenticated;
                case Conditions.RoleAdmin:
                    return User.IsInRole("Admin");
                case Conditions.Normal:
                    return true;
                default:
                    return false;
            }
        }
    }
}
