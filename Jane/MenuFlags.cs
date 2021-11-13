using System;

namespace Jane
{
    [Flags]
    public enum MenuFlags : uint
    {
			/// <summary>
			/// Indicates that the uPosition parameter gives the identifier of the menu item. The MF_BYCOMMAND flag is the default if neither
			/// the MF_BYCOMMAND nor MF_BYPOSITION flag is specified.
			/// </summary>
			MF_BYCOMMAND = 0x00000000,

			/// <summary>
			/// Indicates that the uPosition parameter gives the zero-based relative position of the new menu item. If uPosition is -1, the
			/// new menu item is appended to the end of the menu.
			/// </summary>
			MF_BYPOSITION = 0x00000400,

			/// <summary>
			/// Draws a horizontal dividing line. This flag is used only in a drop-down menu, submenu, or shortcut menu. The line cannot be
			/// grayed, disabled, or highlighted. The lpNewItem and uIDNewItem parameters are ignored.
			/// </summary>
			MF_SEPARATOR = 0x00000800,

			/// <summary>Enables the menu item so that it can be selected, and restores it from its grayed state.</summary>
			MF_ENABLED = 0x00000000,

			/// <summary>Disables the menu item and grays it so that it cannot be selected.</summary>
			MF_GRAYED = 0x00000001,

			/// <summary>Disables the menu item so that it cannot be selected, but the flag does not gray it.</summary>
			MF_DISABLED = 0x00000002,

			/// <summary>
			/// Does not place a check mark next to the item (default). If the application supplies check-mark bitmaps (see
			/// SetMenuItemBitmaps), this flag displays the clear bitmap next to the menu item.
			/// </summary>
			MF_UNCHECKED = 0x00000000,

			/// <summary>
			/// Places a check mark next to the menu item. If the application provides check-mark bitmaps (see SetMenuItemBitmaps, this flag
			/// displays the check-mark bitmap next to the menu item.
			/// </summary>
			MF_CHECKED = 0x00000008,

			/// <summary>Undocumented.</summary>
			MF_USECHECKBITMAPS = 0x00000200,

			/// <summary>Specifies that the menu item is a text string; the lpNewItem parameter is a pointer to the string.</summary>
			MF_STRING = 0x00000000,

			/// <summary>Uses a bitmap as the menu item. The lpNewItem parameter contains a handle to the bitmap.</summary>
			MF_BITMAP = 0x00000004,

			/// <summary>
			/// Specifies that the item is an owner-drawn item. Before the menu is displayed for the first time, the window that owns the
			/// menu receives a WM_MEASUREITEM message to retrieve the width and height of the menu item. The WM_DRAWITEM message is then
			/// sent to the window procedure of the owner window whenever the appearance of the menu item must be updated.
			/// </summary>
			MF_OWNERDRAW = 0x00000100,

			/// <summary>
			/// Specifies that the menu item opens a drop-down menu or submenu. The uIDNewItem parameter specifies a handle to the drop-down
			/// menu or submenu. This flag is used to add a menu name to a menu bar, or a menu item that opens a submenu to a drop-down menu,
			/// submenu, or shortcut menu.
			/// </summary>
			MF_POPUP = 0x00000010,

			/// <summary>
			/// Functions the same as the MF_MENUBREAK flag for a menu bar. For a drop-down menu, submenu, or shortcut menu, the new column
			/// is separated from the old column by a vertical line.
			/// </summary>
			MF_MENUBARBREAK = 0x00000020,

			/// <summary>
			/// Places the item on a new line (for a menu bar) or in a new column (for a drop-down menu, submenu, or shortcut menu) without
			/// separating columns.
			/// </summary>
			MF_MENUBREAK = 0x00000040,

			/// <summary>Removes highlighting from the menu item.</summary>
			MF_UNHILITE = 0x00000000,

			/// <summary>Highlights the menu item. If this flag is not specified, the highlighting is removed from the item.</summary>
			MF_HILITE = 0x00000080,

			/// <summary>Undocumented.</summary>
			MF_DEFAULT = 0x00001000,

			/// <summary>
			/// Item is contained in the window menu. The lParam parameter contains a handle to the menu associated with the message.
			/// </summary>
			MF_SYSMENU = 0x00002000,

			/// <summary>Indicates that the menu item has a vertical separator to its left.</summary>
			MF_HELP = 0x00004000,

			/// <summary>Indicates that the menu item has a vertical separator to its left.</summary>
			MF_RIGHTJUSTIFY = 0x00004000,

			/// <summary>Item is selected with the mouse.</summary>
			MF_MOUSESELECT = 0x00008000,

			/// <summary>Undocumented.</summary>
			MF_END = 0x00000080,
    }


	//public class MenuItemConsts
	//{
	//	internal const uint MF_INSERT = 0x00000000;
	//	internal const uint MF_CHANGE = 0x00000080;
	//	internal const uint MF_APPEND = 0x00000100;
	//	internal const uint MF_DELETE = 0x00000200;
	//	internal const uint MF_REMOVE = 0x00001000;

	//	internal const uint MF_BYCOMMAND = 0x00000000;
	//	internal const uint MF_BYPOSITION = 0x00000400;

	//	internal const uint MF_SEPARATOR = 0x00000800;

	//	internal const uint MF_ENABLED = 0x00000000;
	//	internal const uint MF_GRAYED = 0x00000001;
	//	internal const uint MF_DISABLED = 0x00000002;

	//	internal const uint MF_UNCHECKED = 0x00000000;
	//	internal const uint MF_CHECKED = 0x00000008;
	//	internal const uint MF_USECHECKBITMAPS = 0x00000200;

	//	internal const uint MF_STRING = 0x00000000;
	//	internal const uint MF_BITMAP = 0x00000004;
	//	internal const uint MF_OWNERDRAW = 0x00000100;

	//	internal const uint MF_POPUP = 0x00000010;
	//	internal const uint MF_MENUBARBREAK = 0x00000020;
	//	internal const uint MF_MENUBREAK = 0x00000040;

	//	internal const uint MF_UNHILITE = 0x00000000;
	//	internal const uint MF_HILITE = 0x00000080;

	//	internal const uint MF_DEFAULT = 0x00001000;
	//	internal const uint MF_SYSMENU = 0x00002000;
	//	internal const uint MF_HELP = 0x00004000;
	//	internal const uint MF_RIGHTJUSTIFY = 0x00004000;

	//	internal const uint MF_MOUSESELECT = 0x00008000;
	//	internal const uint MF_END = 0x00000080;  /* Obsolete -- only used by old RES files */

	//	internal const uint MFT_STRING = MF_STRING;
	//	internal const uint MFT_BITMAP = MF_BITMAP;
	//	internal const uint MFT_MENUBARBREAK = MF_MENUBARBREAK;
	//	internal const uint MFT_MENUBREAK = MF_MENUBREAK;
	//	internal const uint MFT_OWNERDRAW = MF_OWNERDRAW;
	//	internal const uint MFT_RADIOCHECK = 0x00000200;
	//	internal const uint MFT_SEPARATOR = MF_SEPARATOR;
	//	internal const uint MFT_RIGHTORDER = 0x00002000;
	//	internal const uint MFT_RIGHTJUSTIFY = MF_RIGHTJUSTIFY;

	//	internal const uint MFS_GRAYED = 0x00000003;
	//	internal const uint MFS_DISABLED = MFS_GRAYED;
	//	internal const uint MFS_CHECKED = MF_CHECKED;
	//	internal const uint MFS_HILITE = MF_HILITE;
	//	internal const uint MFS_ENABLED = MF_ENABLED;
	//	internal const uint MFS_UNCHECKED = MF_UNCHECKED;
	//	internal const uint MFS_UNHILITE = MF_UNHILITE;
	//	internal const uint MFS_DEFAULT = MF_DEFAULT;
	//}
}
