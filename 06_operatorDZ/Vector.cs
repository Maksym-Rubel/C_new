using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _06_operatorDZ
{
    internal class Vector1
    {
        private int xnum;
        private int ynum;

        public int Xnum { get => xnum; set => xnum = value; }
        public int Ynum { get => ynum; set => ynum = value; }
        public Vector1(int xnum, int ynum)
        {
            Xnum = xnum;
            Ynum = ynum;
        }
        public override string ToString()
        {
            return $"({xnum};{ynum})";
        }
        public double Length
        {
            get { return Math.Sqrt(xnum * xnum + ynum * ynum); }
        }
        public static Vector1 operator +(Vector1 a, Vector1 b)
        {
            int x1 = a.xnum + b.xnum;
            int y1 = a.ynum + b.ynum;

            return new Vector1(x1, y1);

        }

    }
}
