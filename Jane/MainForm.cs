using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jane
{
    public partial class MainForm : Form
    {

        private IWindow currentWindow = null;

        public MainForm()
        {
            InitializeComponent();
        }

        public IWindow CurrentWindow
        {
            get => currentWindow;
            set
            {
                currentWindow = value;

                WindowListBox.Items.Clear();
                if (currentWindow == null)
                {
                    HwndTextBox.Text = string.Empty;
                    WindowTitleTextBox.Text = string.Empty;
                }
                else
                {
                    HwndTextBox.Text = currentWindow.Hwnd.ToString();
                    WindowTitleTextBox.Text = currentWindow.Name;
                }
            }
        }


        private async void BtnListWindows_Click(object sender, EventArgs e)
        {
            try
            {
                await ProcessWindowAndChildren(CurrentWindow, false);
            }
            catch
            {
                // ignore for now
            }
        }

        private async void BtnEnableWindows_Click(object sender, EventArgs e)
        {
            try
            {
                await ProcessWindowAndChildren(CurrentWindow, true);
            }
            catch
            {
                // ignore for now
            }
        }

        private async Task ProcessWindowAndChildren(IWindow window, bool enable)
        {
            if (window == null)
            {
                return;
            }
            WindowListBox.Items.Clear();

            var windows = CurrentWindow.GetChildren();
            if (enable)
            {
                await Task.Delay(1500);
                window.Enable();
            }
            foreach (var childWindow in windows)
            {
                if (enable)
                {
                    childWindow.Enable();
                }
                WindowListBox.Items.Add(childWindow);
            }
        }

        private async void BtnListMenus_Click(object sender, EventArgs e)
        {
            try
            {
                await ProcessMenu(CurrentWindow?.Menu, false);
            }
            catch
            {
                // ignore for now
            }
        }


        private async void BtnEnableMenu_Click(object sender, EventArgs e)
        {
            try
            {
                await ProcessMenu(CurrentWindow?.Menu, true);
            }
            catch
            {
                // ignore for now
            }
        }


        private async Task ProcessMenu(IMenu menu, bool enable)
        {
            if (menu == null)
            {
                return;
            }
            WindowListBox.Items.Clear();
            var menuItems = menu.GetAllMenuItems();
            if (enable)
            {
                await Task.Delay(1500);
            }
            foreach (var menuItem in menuItems)
            {
                WindowListBox.Items.Add(menuItem);
                if (enable)
                {
                    menuItem.Enable();
                }
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = WindowListBox.SelectedItem;
            if (item == null)
            {
                return;
            }

            switch (item)
            {
                case IWindow window:
                    new WindowForm(window).Show();
                    break;
                case IMenuItem menuItem:
                    new MenuItemForm(menuItem).Show();
                    break;
                default:
                    return;
            }
        }

        private void DragLabel_MouseDown(object sender, MouseEventArgs e)
        {
            DragLabel.DoDragDrop(DragLabel.Text, DragDropEffects.Link);
        }

        private void DragLabel_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            // TODO: refactor
            CurrentWindow = Window.FromCursor();
        }

        private void WindowTitleTextBox_Leave(object sender, EventArgs e)
        {
            // TODO: refactor
            CurrentWindow = Window.FromName(WindowTitleTextBox.Text);
        }
    }
}
