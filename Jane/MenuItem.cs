using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Jane
{
    public class MenuItem : IMenuItem
    {
        private static class NativeMethods
        {
            #region Menu
            [DllImport("user32.dll")]
            public static extern int GetMenuString(HMENU hMenu, uint uIDItem, [Out] StringBuilder lpString, int nMaxCount, MenuFlags uFlag);

            [DllImport("user32.dll")]
            public static extern HMENU GetSubMenu(HMENU hMenu, uint nPos);

            [DllImport("user32.dll")]
            public static extern bool EnableMenuItem(HMENU hMenu, uint uIDEnableItem, MenuFlags uEnable);

            [DllImport("user32.dll")]
            public static extern bool ModifyMenu(HMENU hMenu, uint uPosition, MenuFlags uFlags, IntPtr uIDNewItem, string lpNewItem);

            [DllImport("user32.dll")]
            public static extern bool ModifyMenu(HMENU hMenu, uint uPosition, MenuFlags uFlags, IntPtr uIDNewItem, IntPtr lpNewItem);

            [DllImport("user32.dll")]
            public static extern MenuFlags GetMenuState(HMENU hMenu, uint uID, MenuFlags uFlags);

            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            public static extern bool GetMenuItemInfo(HMENU hMenu, uint uItem, bool fByPosition, [In, Out] MENUITEMINFO lpmii);


            [DllImport("user32.dll", SetLastError = false, ExactSpelling = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool HiliteMenuItem(HWND hWnd, HMENU hMenu, uint uIDHiliteItem, MenuFlags uHilite);

            #endregion

            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
            public class MENUITEMINFO
            {
                public int cbSize = Marshal.SizeOf(typeof(MENUITEMINFO));
                public MIIM fMask;
                public uint fType;
                public uint fState;
                public uint wID;
                public IntPtr hSubMenu;
                public IntPtr hbmpChecked;
                public IntPtr hbmpUnchecked;
                public IntPtr dwItemData;
                public string dwTypeData = null;
                public uint cch; // length of dwTypeData
                public IntPtr hbmpItem;

                public MENUITEMINFO() { }
                public MENUITEMINFO(MIIM pfMask)
                {
                    fMask = pfMask;
                }
            }

            [Flags]
            public enum MIIM
            {
                BITMAP = 0x00000080,
                CHECKMARKS = 0x00000008,
                DATA = 0x00000020,
                FTYPE = 0x00000100,
                ID = 0x00000002,
                STATE = 0x00000001,
                STRING = 0x00000040,
                SUBMENU = 0x00000004,
                TYPE = 0x00000010
            }
        }

        public MenuItem(IWindow window, HMENU hMenu, uint index)
        {
            Window = window;
            HMenu = hMenu;
            Index = index;
        }

        public IWindow Window { get; }
        public HMENU HMenu { get; }
        public uint Index { get; }

        public string Name
        {
            get
            {
                StringBuilder menuName = new StringBuilder(0x1001);
                NativeMethods.GetMenuString(HMenu, Index, menuName, 0x1000, MenuFlags.MF_BYPOSITION);
                return menuName.ToString().Replace("\n", "");
            }
        }

        public MenuFlags GetMenuItemState()
        {
            try
            {
                return NativeMethods.GetMenuState(HMenu, Index, MenuFlags.MF_BYPOSITION);
            }
            catch
            {
                return MenuFlags.MF_ENABLED;
            }
        }

        public uint GetMenuItemInfo()
        {
            throw new NotImplementedException();

            //var menuItemInfo = new NativeMethods.MENUITEMINFO(NativeMethods.MIIM.STRING | NativeMethods.MIIM.ID);
            //if (NativeMethods.GetMenuItemInfo(HMenu, 0, true, menuItemInfo))
            //{
            //    ++menuItemInfo.cch;
            //    menuItemInfo.dwTypeData = new String(' ', (int)menuItemInfo.cch);
            //    res = NativeMethods.GetMenuItemInfo(HMenu, 0, true, menuItemInfo);
            //}
        }

        public bool Enable()
        {
            return NativeMethods.EnableMenuItem(HMenu, Index, MenuFlags.MF_BYPOSITION | MenuFlags.MF_ENABLED);
        }
        /// <summary>
        /// Disabled menu looks just like an enabled item
        /// </summary>
        public bool Disable()
        {
            return NativeMethods.EnableMenuItem(HMenu, Index, MenuFlags.MF_BYPOSITION | MenuFlags.MF_DISABLED);
        }
        public bool Gray()
        {
            return NativeMethods.EnableMenuItem(HMenu, Index, MenuFlags.MF_BYPOSITION | MenuFlags.MF_GRAYED);
        }

        public bool ModifyMenu(MenuFlags flag, uint uIDNewItem, string lpNewItem)
        {
            try
            {
                if (string.IsNullOrEmpty(lpNewItem))
                {
                    return NativeMethods.ModifyMenu(HMenu, Index, MenuFlags.MF_BYPOSITION | flag, new IntPtr(uIDNewItem), IntPtr.Zero);
                }
                return NativeMethods.ModifyMenu(HMenu, Index, MenuFlags.MF_BYPOSITION | flag, new IntPtr(uIDNewItem), lpNewItem);
            }
            catch
            {
                // ignore
                return false;
            }
        }


        public bool Hilite()
        {
            return NativeMethods.HiliteMenuItem(Window.Hwnd, HMenu, Index, MenuFlags.MF_BYPOSITION | MenuFlags.MF_HILITE);
        }

        public bool UnHilite()
        {
            return NativeMethods.HiliteMenuItem(Window.Hwnd, HMenu, Index, MenuFlags.MF_BYPOSITION | MenuFlags.MF_UNHILITE);
        }

        public IMenu GetSubMenu()
        {
            var hSubmenu = NativeMethods.GetSubMenu(HMenu, Index);
            if (hSubmenu == IntPtr.Zero)
            {
                return null;
            }
            return new Menu(Window, hSubmenu);
        }

        public override string ToString()
        {
            return $"{HMenu}-{Index}\t{Name}";
        }
    }
}
