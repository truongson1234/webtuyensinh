using webtuyensinh.Models;

namespace webtuyensinh.ViewModels
{
    public class MenuViewModel
    {
        public MenuItemModel Menu { get; set; }
        public MenuModel MenuGroup { get; set; }
        public IEnumerable<MenuItemModel> Menus { get; set; }
        public IEnumerable<MenuItemModel> ParentMenus { get; set; }
        public IEnumerable<MenuModel> MenuGroups { get; set; }

    }
}
