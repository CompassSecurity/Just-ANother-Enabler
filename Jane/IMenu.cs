using System.Collections.Generic;

namespace Jane
{
    public interface IMenu
    {
        HMENU HMenu { get; }
        int MenuItemCount { get; }
        IWindow Window { get; }

        IList<IMenuItem> GetAllMenuItems();
        IList<IMenuItem> GetDirectMenuItems();
    }
}