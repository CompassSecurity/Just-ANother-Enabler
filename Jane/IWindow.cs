using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Jane
{
    public interface IWindow
    {
        string ClassName { get; }
        HWND Hwnd { get; }
        Menu Menu { get; }
        string Name { get; set; }
        Window Parent { get; }
        Process Process { get; }
        string RealWindowClass { get; }
        RECT Rect { get; }
        WindowStyles WindowStyles { get; }

        bool Cloak();
        bool Disable();
        bool Enable();
        IList<Window> GetChildren();
        bool IsCloaked();
        bool IsEnabled();
        bool IsIconic();
        bool IsVisible();
        void PostMessage(WindowMessage msg, IntPtr wParam, IntPtr lParam);
        void SetForeground();
        void ShowWindow(CmdShowWindow nCmdShow);
        string ToShortString();
        string ToString();
    }
}