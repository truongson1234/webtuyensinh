using webtuyensinh.Models;

namespace webtuyensinh.ViewModels
{
    public class MenuViewModel
    {
        public MenuModel Menu { get; set; }
        public MenuGroupModel MenuGroup { get; set; }
        public IEnumerable<MenuModel> Menus { get; set; }
        public IEnumerable<MenuGroupModel> MenuGroups { get; set; }

    }
}
