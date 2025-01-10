using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_structure
{
    struct Fraction
    {
        public int num;
        public int denom;


        public Fraction(int num, int denom)
        {
            this.num = num;
            this.denom = denom;
        }
        public override string ToString()
        {
            return $"{num}/{denom}";
        }

        public static Fraction Add(Fraction one, Fraction two)
        {
            int num = one.num * two.denom + two.num * one.denom;
            int num2 = two.denom * one.denom;
            return new Fraction(num, num2);
        }
        public static Fraction Substract(Fraction one, Fraction two)
        {
            int num = one.num * two.denom - two.num * one.denom;
            int num2 = two.denom * one.denom;
            return new Fraction(num, num2);
        }
        public static Fraction Mnoz(Fraction one, Fraction two)
        {
            int num = one.num * two.num;
            int num2 = two.denom * one.denom;
            return new Fraction(num, num2);
        }
        public static Fraction Dilenia(Fraction one, Fraction two)
        {
            int num = one.num * two.denom;
            int num2 = one.denom * two.num;
            return new Fraction(num, num2);
        }
    }
}
