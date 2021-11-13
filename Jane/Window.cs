using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace Jane
{
    public class Window : IWindow
    {
        private static class NativeMethods
        {
            #region Window

            [DllImport("user32.dll", SetLastError = false)]
            public static extern HWND GetDesktopWindow();

            [DllImport("user32.dll", SetLastError = true)]
            public static extern HWND FindWindow(string lpClassName, string lpWindowName);

            [DllImport("user32.dll")]
            public static extern HWND GetForegroundWindow();

            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool SetForegroundWindow(HWND hWnd);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern int GetWindowText(HWND hWnd, StringBuilder lpString, int nMaxCount);

            [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
            public static extern bool SetWindowText(HWND hwnd, String lpString);

            [DllImport("user32.dll")]
            public static extern bool ShowWindow(HWND hWnd, CmdShowWindow nCmdShow);

            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetWindowRect(HWND hWnd, out RECT lpRect);

            [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
            public static extern bool GetClientRect(HWND hwnd, out RECT rc);

            [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
            public static extern int GetClassName(HWND hWnd, StringBuilder lpClassName, int nMaxCount);

            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool EnableWindow(HWND hWnd, bool bEnable);

            [DllImport("user32.dll")]
            public static extern HWND WindowFromPoint(POINT p);

            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            public static extern bool IsWindowEnabled(HWND hwnd);

            [DllImport("user32.dll")]
            public static extern bool IsWindowVisible(HWND hwnd);


            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            public static extern bool IsWindow(HWND hwnd);

            [DllImport("user32.dll")]
            public static extern bool IsIconic(HWND hwnd);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern int RealGetWindowClass(HWND hWnd, StringBuilder classname, int nMax);

            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            internal extern static bool IsChild(HWND parent, HWND child);

            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool EnumChildWindows(HWND hwndParent, EnumWindowsProc lpEnumFunc, IntPtr lParam);
            public delegate bool EnumWindowsProc(IntPtr hwnd, IntPtr lParam);

            [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
            public static extern HWND GetParent(HWND hWnd);

            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            public static extern HWND GetAncestor(HWND hwnd, int gaFlags);


            [return: MarshalAs(UnmanagedType.Bool)]
            [DllImport("user32.dll", SetLastError = true)]
            public static extern bool PostMessage(HWND hWnd, WindowMessage Msg, IntPtr wParam, IntPtr lParam);

            #endregion

            #region Cursor

            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetCursorPos(out POINT lpPoint);


            /// <summary>
            /// SetWindowPos Flags
            /// </summary>
            [Flags]
            public enum SWP
            {
                NOSIZE = 0x0001,
                NOMOVE = 0x0002,
                NOZORDER = 0x0004,
                NOREDRAW = 0x0008,
                NOACTIVATE = 0x0010,
                DRAWFRAME = 0x0020,
                FRAMECHANGED = 0x0020,
                SHOWWINDOW = 0x0040,
                HIDEWINDOW = 0x0080,
                NOCOPYBITS = 0x0100,
                NOOWNERZORDER = 0x0200,
                NOREPOSITION = 0x0200,
                NOSENDCHANGING = 0x0400,
                DEFERERASE = 0x2000,
                ASYNCWINDOWPOS = 0x4000,
            }

            /// <summary>
            ///     Changes the size, position, and Z order of a child, pop-up, or top-level window. These windows are ordered
            ///     according to their appearance on the screen. The topmost window receives the highest rank and is the first window
            ///     in the Z order.
            /// </summary>
            /// <remarks>
            ///     <para>
            ///     A window can be made a topmost window either by setting the hWndInsertAfter parameter to HWND_TOPMOST and
            ///     ensuring that the SWP_NOZORDER flag is not set, or by setting a window's position in the Z order so that it is
            ///     above any existing topmost windows. When a non-topmost window is made topmost, its owned windows are also made
            ///     topmost. Its owners, however, are not changed.
            ///     </para>
            /// </remarks>
            [DllImport("user32.dll", SetLastError = true)]
            static extern bool SetWindowPos(HWND hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, SWP uFlags);

            #endregion

            #region DWM

            [Flags]
            public enum DWMWINDOWATTRIBUTE : uint
            {
                DWMWA_NCRENDERING_ENABLED = 1,
                DWMWA_NCRENDERING_POLICY,
                DWMWA_TRANSITIONS_FORCEDISABLED,
                DWMWA_ALLOW_NCPAINT,
                DWMWA_CAPTION_BUTTON_BOUNDS,
                DWMWA_NONCLIENT_RTL_LAYOUT,
                DWMWA_FORCE_ICONIC_REPRESENTATION,
                DWMWA_FLIP3D_POLICY,
                DWMWA_EXTENDED_FRAME_BOUNDS,
                DWMWA_HAS_ICONIC_BITMAP,
                DWMWA_DISALLOW_PEEK,
                DWMWA_EXCLUDED_FROM_PEEK,
                DWMWA_CLOAK,
                DWMWA_CLOAKED,
                DWMWA_FREEZE_REPRESENTATION,
                DWMWA_LAST
            }

            [DllImport("DwmApi.dll")]
            public static extern int DwmGetWindowAttribute(HWND hwnd, DWMWINDOWATTRIBUTE dwAttribute, ref int pvAttribute, int cbAttribute);

            [DllImport("dwmapi.dll", PreserveSig = true)]
            public static extern int DwmSetWindowAttribute(IntPtr hwnd, DWMWINDOWATTRIBUTE attr, ref int attrValue, int attrSize);

            #endregion

            #region Monitor

            public const int MONITOR_DEFAULTTONULL = 0x00000000;

            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            public static extern IntPtr MonitorFromRect(ref RECT rect, int dwFlags);

            #endregion

            #region Process

            [DllImport("user32.dll", SetLastError = true)]
            public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

            // When you don't want the ProcessId, use this overload and pass IntPtr.Zero for the second parameter
            [DllImport("user32.dll")]
            public static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);

            #endregion

            #region GetWindowLong

            [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
            private static extern IntPtr GetWindowLongPtr32(IntPtr hWnd, GWL nIndex);

            [DllImport("user32.dll", EntryPoint = "GetWindowLongPtr")]
            private static extern IntPtr GetWindowLongPtr64(IntPtr hWnd, GWL nIndex);

            // This static method is required because Win32 does not support
            // GetWindowLongPtr directly
            public static IntPtr GetWindowLongPtr(IntPtr hWnd, GWL nIndex)
            {
                return IntPtr.Size == 8 ? GetWindowLongPtr64(hWnd, nIndex) : GetWindowLongPtr32(hWnd, nIndex);
            }

            public enum GWL
            {
                GWL_WNDPROC = -4,
                GWL_HINSTANCE = -6,
                GWL_HWNDPARENT = -8,
                GWL_ID = -12,
                GWL_STYLE = -16,
                GWL_EXSTYLE = -20,
                GWL_USERDATA = -21
            }

            #endregion
        }

        public Window(HWND hwnd)
        {
            if (hwnd == IntPtr.Zero)
            {
                throw new ArgumentNullException(nameof(hwnd));
            }
            Hwnd = hwnd;
        }

        public HWND Hwnd
        {
            get;
            private set;
        }

        public WindowStyles WindowStyles
        {
            get
            {
                var windowLong = NativeMethods.GetWindowLongPtr(Hwnd, NativeMethods.GWL.GWL_STYLE);
                var windowStyle = (WindowStyles)windowLong;
                return windowStyle;
            }
        }

        public Window Parent
        {
            get
            {
                HWND hwnd = NativeMethods.GetParent(Hwnd);
                if (hwnd == IntPtr.Zero)
                {
                    // An error occured
                    // throw new Win32Exception(Marshal.GetLastWin32Error());
                    return null;
                }
                return new Window(hwnd);
            }
        }

        public string Name
        {
            get
            {
                // TODO: could call GetWindowTextLengthA first
                var sb = new StringBuilder(1001);
                if (NativeMethods.GetWindowText(Hwnd, sb, 1000) > 0)
                {
                    return sb.ToString().Replace("\n", "");
                }
                return string.Empty;
            }
            set
            {
                // TODO: Check return/exceptions
                NativeMethods.SetWindowText(Hwnd, value);
            }
        }

        public string ClassName
        {
            get
            {
                var sb = new StringBuilder(260);
                if (NativeMethods.GetClassName(Hwnd, sb, 259) > 0)
                {
                    return sb.ToString().Replace("\n", "");
                }
                return string.Empty;
            }
        }

        public string RealWindowClass
        {
            get
            {
                StringBuilder str = new StringBuilder(260);
                // TODO: implement success check
                NativeMethods.RealGetWindowClass(Hwnd, str, 259);
                return str.ToString().Replace("\n", "");
            }
        }

        public Process Process
        {
            get
            {
                try
                {
                    NativeMethods.GetWindowThreadProcessId(Hwnd, out var procID);
                    return Process.GetProcessById(procID);
                }
                catch
                {
                    return null;
                }

            }
        }

        public Menu Menu
        {
            get => Menu.FromWindowHandle(Hwnd);
        }
        public RECT Rect
        {
            get
            {
                NativeMethods.GetWindowRect(Hwnd, out var rect);
                return rect;
            }
        }

        public IList<Window> GetChildren()
        {
            List<IntPtr> result = new List<IntPtr>();
            GCHandle listHandle = GCHandle.Alloc(result);
            try
            {
                NativeMethods.EnumChildWindows(Hwnd, EnumWindow, GCHandle.ToIntPtr(listHandle));
                foreach (var childHwnd in listHandle.Target as List<IntPtr>)
                {
                    var childWindow = new Window(HWND.Cast(childHwnd));
                }
            }
            finally
            {
                if (listHandle.IsAllocated)
                {
                    listHandle.Free();
                }
            }
            return result.ConvertAll(x => new Window(HWND.Cast(x)));
        }

        /// <summary>
        /// Callback method to be used when enumerating windows.
        /// </summary>
        /// <param name="handle">Handle of the next window</param>
        /// <param name="pointer">Pointer to a GCHandle that holds a reference to the list to fill</param>
        /// <returns>True to continue the enumeration, false to bail</returns>
        private static bool EnumWindow(IntPtr handle, IntPtr pointer)
        {
            GCHandle gch = GCHandle.FromIntPtr(pointer);
            IList<IntPtr> list = gch.Target as List<IntPtr>;
            if (list == null)
            {
                return false;
            }
            list.Add(handle);
            //  You can modify this to check to see if you want to cancel the operation, then return a null here
            return true;
        }

        /// <summary>
        /// Cloaking is a way to hide a window while it still is technically open so it
        /// continues to render/update, so thumbnails and such stay alive, but the window is off screen.
        /// </summary>
        public bool IsCloaked()
        {
            int dwCloaked = 0;

            if (NativeMethods.DwmGetWindowAttribute(Hwnd, NativeMethods.DWMWINDOWATTRIBUTE.DWMWA_CLOAKED, ref dwCloaked, sizeof(int)) == 0)
            {
                //DWM_CLOAKED_APP(value 0x0000001).The window was cloaked by its owner application.
                //DWM_CLOAKED_SHELL(value 0x0000002).The window was cloaked by the Shell.
                //DWM_CLOAKED_INHERITED(value 0x0000004).The cloak value was inherited from its owner window.
                return dwCloaked != 0;
            }
            return false;
        }

        /// <summary>
        /// !!! Only system shell and application itself can set cloak, third-party process will be denied !!!
        /// </summary>
        public bool Cloak()
        {
            int value = 0x01;
            int hresult = NativeMethods.DwmSetWindowAttribute(Hwnd, NativeMethods.DWMWINDOWATTRIBUTE.DWMWA_CLOAK, ref value, Marshal.SizeOf(typeof(int)));
            if (hresult == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsVisible()
        {
            return NativeMethods.IsWindowVisible(Hwnd);
        }

        public bool IsIconic()
        {
            return NativeMethods.IsIconic(Hwnd);
        }

        public bool IsEnabled()
        {
            return NativeMethods.IsWindowEnabled(Hwnd);
        }

        public bool Enable()
        {
            return NativeMethods.EnableWindow(Hwnd, true);
        }

        public bool Disable()
        {
            return NativeMethods.EnableWindow(Hwnd, false);
        }

        public void ShowWindow(CmdShowWindow nCmdShow)
        {
            NativeMethods.ShowWindow(Hwnd, nCmdShow);
        }

        public void SetForeground()
        {
            NativeMethods.SetForegroundWindow(Hwnd);
        }

        public void PostMessage(WindowMessage msg, IntPtr wParam, IntPtr lParam)
        {
            NativeMethods.PostMessage(Hwnd, msg, wParam, lParam);
        }

        public override string ToString()
        {
            return $"{Hwnd}\t{Name} ({ClassName})";
        }

        public string ToShortString()
        {
            return $"{Hwnd} {Name}";
        }

        public static Window GetDesktopWindow()
        {
            var hwnd = NativeMethods.GetDesktopWindow();
            if (hwnd == null)
            {
                return null;
            }
            return new Window(hwnd);
        }

        // TODO: refactor
        public static Window FromName(string windowName)
        {
            if (string.IsNullOrWhiteSpace(windowName))
            {
                return null;
            }
            var hwnd = NativeMethods.FindWindow(null, windowName);
            if (hwnd == IntPtr.Zero)
            {
                return null;
            }
            return new Window(hwnd);
        }

        // TODO: refactor
        public static Window FromProcessName(string processName)
        {
            if (processName == null)
            {
                return null;
            }
            var procs = Process.GetProcessesByName(processName);
            if (procs == null || procs[0] == null)
            {
                return null;
            }
            var hwnd = HWND.Cast(procs[0].MainWindowHandle);
            if (hwnd == IntPtr.Zero)
            {
                return null;
            }
            return new Window(hwnd);
        }

        public static Window FromCursor()
        {
            NativeMethods.GetCursorPos(out POINT point);
            if (point == default)
            {
                return null;
            }
            return FromPoint(point);
        }

        // TODO: refactor
        public static Window FromPoint(POINT point)
        {
            HWND hwnd = NativeMethods.WindowFromPoint(point);
            if (hwnd == IntPtr.Zero)
            {
                return null;
            }
            return new Window(hwnd);
        }
    }
}
