using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Jane
{
    public class Menu : IMenu
    {
        private static class NativeMethods
        {
            #region Menu
            [DllImport("user32.dll")]
            public static extern HMENU GetMenu(HWND hWnd);

            [DllImport("user32.dll")]
            public static extern HMENU GetSystemMenu(HWND hWnd, bool bRevert);

            [DllImport("user32.dll")]
            public static extern int GetMenuItemCount(HMENU hMenu);
            #endregion
        }

        public Menu(IWindow window, HMENU hMenu)
        {
            Window = window ?? throw new ArgumentNullException(nameof(window));
            if (hMenu == IntPtr.Zero)
            {
                throw new ArgumentNullException(nameof(hMenu));
            }
            HMenu = hMenu;
        }

        public IWindow Window { get; }
        public HMENU HMenu { get; }

        public int MenuItemCount
        {
            get => NativeMethods.GetMenuItemCount(HMenu);
        }

        public IList<IMenuItem> GetDirectMenuItems()
        {
            var count = MenuItemCount;
            if (count <= 0)
            {
                return new List<IMenuItem>();
            }

            var result = new List<IMenuItem>();
            for (uint i = 0; i < count; i++)
            {
                // TODO: refactor
                result.Add(new MenuItem(Window, HMenu, i));
            }
            return result;
        }

        public IList<IMenuItem> GetAllMenuItems()
        {
            var list = new List<IMenuItem>();
            GetAllMenuItems(this, list);
            return list;
        }

        private static void GetAllMenuItems(IMenu currentMenu, IList<IMenuItem> menuItems)
        {
            if (currentMenu == null)
            {
                return;
            }
            var currentMenuItems = currentMenu.GetDirectMenuItems();
            foreach (var menuItem in currentMenuItems)
            {
                menuItems.Add(menuItem);
                GetAllMenuItems(menuItem.GetSubMenu(), menuItems);
            }
        }

        public static Menu FromWindowHandle(HWND hwnd)
        {
            if (hwnd == IntPtr.Zero)
            {
                return null;
            }

            var hMenu = NativeMethods.GetMenu(hwnd);
            if (hMenu == IntPtr.Zero)
            {
                return null;
            }

            return new Menu(new Window(hwnd), hMenu);
        }
    }
}
