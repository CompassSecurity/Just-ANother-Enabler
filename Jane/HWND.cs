using System;
using System.Runtime.InteropServices;

namespace Jane
{
    [StructLayout(LayoutKind.Sequential)]
    public struct HWND
    {
        public IntPtr hwnd;

        public override string ToString()
        {
            return hwnd.ToString();
        }

        public override bool Equals(object oCompare)
        {
            HWND hr = Cast((HWND)oCompare);
            return hwnd == hr.hwnd;
        }

        public override int GetHashCode()
        {
            return (int)hwnd;
        }

        public static HWND Cast(IntPtr hwndPtr)
        {
            return new HWND
            {
                hwnd = hwndPtr
            };
        }

        public static implicit operator IntPtr(HWND h)
        {
            return h.hwnd;
        }

        public static HWND NULL
        {
            get
            {
                HWND hTemp = new HWND
                {
                    hwnd = IntPtr.Zero
                };
                return hTemp;
            }
        }

        public static bool operator ==(HWND hl, HWND hr)
        {
            return hl.hwnd == hr.hwnd;
        }

        public static bool operator !=(HWND hl, HWND hr)
        {
            return hl.hwnd != hr.hwnd;
        }
    }
}
