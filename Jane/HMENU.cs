using System;
using System.Runtime.InteropServices;

namespace Jane
{
    [StructLayout(LayoutKind.Sequential)]
    public struct HMENU
    {
        public IntPtr hMenu;

        public override string ToString()
        {
            return hMenu.ToString();
        }

        public override bool Equals(object oCompare)
        {
            HMENU hr = Cast((HMENU)oCompare);
            return hMenu == hr.hMenu;
        }

        public override int GetHashCode()
        {
            return (int)hMenu;
        }

        public static HMENU Cast(IntPtr hMenuPtr)
        {
            return new HMENU
            {
                hMenu = hMenuPtr
            };
        }

        public static implicit operator IntPtr(HMENU h)
        {
            return h.hMenu;
        }

        public static HMENU NULL
        {
            get
            {
                HMENU hTemp = new HMENU
                {
                    hMenu = IntPtr.Zero
                };
                return hTemp;
            }
        }

        public static bool operator ==(HMENU hl, HMENU hr)
        {
            return hl.hMenu == hr.hMenu;
        }

        public static bool operator !=(HMENU hl, HMENU hr)
        {
            return hl.hMenu != hr.hMenu;
        }
    }
}
