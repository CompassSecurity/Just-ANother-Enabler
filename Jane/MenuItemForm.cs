using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jane
{
    public partial class MenuItemForm : Form
    {
        public MenuItemForm(IMenuItem menuItem)
        {
            MenuItem = menuItem ?? throw new ArgumentNullException(nameof(menuItem));
            InitializeComponent();

            Text = $"Menu: {MenuItem}";
            HMenuTextBox.Text = MenuItem.HMenu.ToString();
            MenuIndexTextBox.Text = MenuItem.Index.ToString();
            MenuTextTextBox.Text = MenuItem.Name;

            MenuStatusTextBox.Text = MenuItem.GetMenuItemState().ToString();
        }

        public IMenuItem MenuItem { get; }

        private void WindowButton_Click(object sender, EventArgs e)
        {
            new WindowForm(MenuItem.Window).Show();
        }

        private async void HiliteButton_Click(object sender, EventArgs e)
        {
            await TaskHelper.Delay(ActionDelay.Value);
            MenuItem.Hilite();
        }

        private async void UnHiliteButton_Click(object sender, EventArgs e)
        {
            await TaskHelper.Delay(ActionDelay.Value);
            MenuItem.UnHilite();
        }

        private async void EnableButton_Click(object sender, EventArgs e)
        {
            await TaskHelper.Delay(ActionDelay.Value);
            MenuItem.Enable();
        }

        private async void DisableButton_Click(object sender, EventArgs e)
        {
            await TaskHelper.Delay(ActionDelay.Value);
            MenuItem.Disable();
        }

        private async void GrayOutButton_Click(object sender, EventArgs e)
        {
            await TaskHelper.Delay(ActionDelay.Value);
            MenuItem.Gray();
        }

        private void ModifyMenuButton_Click(object sender, EventArgs e)
        {
            if (!Enum.TryParse<MenuFlags>(MenuFlagsComboBox.SelectedItem as string, out var menuFlags))
            {
                return;
            }
            var uIDNewItem = decimal.ToUInt32(UIDNewItemUpDown.Value);
            var text = LpNewItemTextBox.Text;
            // TODO: WatermarkTextbox?
            if (text == "lpNewItem")
            {
                text = null;
            }
            MenuItem.ModifyMenu(menuFlags, uIDNewItem, text);
        }
    }
}
