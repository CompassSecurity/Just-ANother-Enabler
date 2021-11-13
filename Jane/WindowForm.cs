using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jane
{
    public partial class WindowForm : Form
    {
        public WindowForm(IWindow window)
        {
            Window = window ?? throw new ArgumentNullException(nameof(window));
            InitializeComponent();
            CmdShowWindowComboBox.DataSource = Enum.GetValues(typeof(CmdShowWindow));
            WindowMessageComboBox.DataSource = Enum.GetValues(typeof(WindowMessage));

            try
            {
                Text = $"Window: {Window.ToShortString()}";
                HwndTextBox.Text = Window.Hwnd.ToString();
                WindowNameTextBox.Text = Window.Name;
                WindowClassTextBox.Text = Window.ClassName;
                RealGetWindowClassTextBox.Text = Window.RealWindowClass;
                SetProcessTextBox();

                WindowStylesTextBox.Text = Window.WindowStyles.ToString();
                WindowRectTextBox.Text = Window.Rect.ToString();
            }
            catch
            {
                // ignore for now..
            }
        }

        private void SetProcessTextBox()
        {
            var process = Window.Process;
            if (process != null)
            {
                try
                {
                    ProcessNameTextBox.Text = process.MainModule?.FileName ?? string.Empty;
                }
                catch
                {
                    ProcessNameTextBox.Text = process.ProcessName;
                }
            }
        }

        public IWindow Window { get; }

        private void SetWindowTitleButton_Click(object sender, EventArgs e)
        {
            Window.Name = WindowNameTextBox.Text;
        }

        private void ParentWindowButton_Click(object sender, EventArgs e)
        {
            var parent = Window.Parent;
            if (parent != null)
            {
                var newWindow = new WindowForm(parent);
                newWindow.Show();
            }
        }

        private async void EnableButton_Click(object sender, EventArgs e)
        {
            await TaskHelper.Delay(EnableWindowDelayUpDown.Value);
            Window.Enable();
        }

        private async void DisableButton_Click(object sender, EventArgs e)
        {
            await TaskHelper.Delay(EnableWindowDelayUpDown.Value);
            Window.Disable();
        }

        private void ShowWindowButton_Click(object sender, EventArgs e)
        {
            try
            {
                var cmd = (CmdShowWindow)CmdShowWindowComboBox.SelectedValue;
                Window.ShowWindow(cmd);
            }
            catch
            {
                // ignore
            }
        }

        private void SetForegroundWindowButton_Click(object sender, EventArgs e)
        {
            Window.SetForeground();
        }

        private void PostMessageButton_Click(object sender, EventArgs e)
        {
            try
            {
                var msg = (WindowMessage)WindowMessageComboBox.SelectedValue;
                Window.PostMessage(msg, new IntPtr(decimal.ToInt32(WparamUpDown.Value)), new IntPtr(decimal.ToInt32(WparamUpDown.Value)));
            }
            catch
            {
                // ignore
            }
        }
    }
}
