using System.Runtime.InteropServices;

namespace Jane
{
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int X;
        public int Y;

        public POINT(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static implicit operator System.Drawing.Point(POINT p)
        {
            return new System.Drawing.Point(p.X, p.Y);
        }

        public static implicit operator POINT(System.Drawing.Point p)
        {
            return new POINT(p.X, p.Y);
        }



        public override string ToString()
        {
            return $"{X}, {Y}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() == typeof(POINT))
            {
                var objPoint = (POINT)obj;
                return objPoint.X == X && objPoint.Y == Y;
            }
            return false;
        }

        public override int GetHashCode() => (X, Y).GetHashCode();

        public static bool operator ==(POINT a, POINT b) => a.Equals(b);
        public static bool operator !=(POINT a, POINT b) => !(a == b);
    }

}
