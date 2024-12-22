using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _06_operatorDZ
{
    internal class MyVector
    {
        private double xnum;
        private double ynum;

        public double Xnum { get => xnum; set => xnum = value; }
        public double Ynum { get => ynum; set => ynum = value; }
        public MyVector(double xnum, double ynum)
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
        public static MyVector operator +(MyVector a, MyVector b)
        {
            double x1 = a.xnum + b.xnum;
            double y1 = a.ynum + b.ynum;

            return new MyVector(x1, y1);

        }
        public static MyVector operator -(MyVector a, MyVector b)
        {
            double x1 = a.xnum - b.xnum;
            double y1 = a.ynum - b.ynum;

            return new MyVector(x1, y1);

        }
        public static MyVector operator *(MyVector a, double num)
        {
            double x1 = a.xnum * num;
            double y1 = a.ynum * num;

            return new MyVector(x1, y1);
        }
        public static MyVector operator *(MyVector a, MyVector b)
        {
            double x1 = a.xnum * a.ynum;
            double y1 = b.xnum * b.ynum;

            return new MyVector(x1, y1);
        }
        public static bool operator ==(MyVector a, MyVector b)
        {
            if (a == null || b == null) return false;
            return a.xnum == b.xnum && a.ynum == b.ynum;


        }
        public static bool operator !=(MyVector a, MyVector b)
        {
            return !(a == b);
        }
        public static MyVector operator ++(MyVector a)
        {
            MyVector vectorr = new MyVector(1, 1);
            return a + vectorr;
        }
        public static MyVector operator --(MyVector a)
        {
            MyVector vectorr = new MyVector(1, 1);
            return a - vectorr;
        }
        public static bool operator true(MyVector a)
        {
            return a.xnum != 0 || a.ynum != 0;
        }
        public static bool operator false(MyVector a)
        {
            return a.xnum == 0 || a.ynum == 0;
        }
        public static explicit operator double(MyVector vector)
        {
            return vector.Length;
        }
        public static implicit operator MyVector(double value)
        {
            return new MyVector(value, 0);
        }
        public double this[int index]
        {
            get
            {
                if (index == 0) return xnum;  
                else if (index == 1) return ynum;
                else throw new IndexOutOfRangeException("Index must be 0 or 1.");
            }
        }
    }
}
