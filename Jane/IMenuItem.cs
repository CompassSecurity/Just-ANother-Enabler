namespace Jane
{
    public interface IMenuItem
    {
        HMENU HMenu { get; }
        uint Index { get; }
        string Name { get; }
        IWindow Window { get; }

        bool Disable();
        bool Enable();
        uint GetMenuItemInfo();
        MenuFlags GetMenuItemState();
        IMenu GetSubMenu();
        bool Gray();
        bool Hilite();
        bool ModifyMenu(MenuFlags flag, uint uIDNewItem, string lpNewItem);
        string ToString();
        bool UnHilite();
    }
}