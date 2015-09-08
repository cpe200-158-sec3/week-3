using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
    public class Fraction
    {
        public static int Count = 0;
        private int num;
        private int den = 1;

        public Fraction()
        {
            this.num = 0;
            this.den = 1;
            Count++;

        }

        public Fraction(int a)
        {
            this.num = a;
            Count++;
        }
        public Fraction(Fraction a)
        {
            this.num = a.num;
            this.den = a.den;
            Count++;
        }

        public Fraction(int a, int b)
        {
            this.num = a;
            this.den = b;
            Count++;
        }


        public void setA(int newA)
        {
            num = newA;
        }

        public void setB(int newB)
        {
            den = newB;
        }

        public void setValue(int newA, int newB)
        {
            this.num = newA;

            if (newB == 0)
            {
                den = 1;
            }
            else
            {
                this.den = newB;

            }
        }

        public void output()
        {
            Console.WriteLine("[Rational: " + num/GCD(num,den) + "/" + den/GCD(num,den) + "], value=" + (num*1.0)/den + "]");
        }

        static int GCD(int[] numbers)
        {
            return numbers.Aggregate(GCD);
        }

        public static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }


        public static Fraction operator *(Fraction frac1, Fraction frac2)
        {
            Fraction frac3 = new Fraction();
            frac3.setA((frac1.num * frac2.num));
            frac3.setB((frac1.den * frac2.den));
            return frac3;
        }

        public static Fraction operator /(Fraction frac1, Fraction frac2)
        {
            Fraction frac4 = new Fraction();
            frac4.setA((frac1.num * frac2.den));
            frac4.setB((frac1.den * frac2.num));
            return frac4;
        }

        public static Fraction operator +(Fraction frac1, Fraction frac2)
        {
            Fraction frac5 = new Fraction();
            frac5.setB((frac1.den * frac2.den));
            frac5.setA(((frac1.num * frac2.den) + (frac2.num * frac1.den)));
            return frac5;
        }



        public static Fraction operator -(Fraction frac1, Fraction frac2)
        {
            Fraction frac6 = new Fraction();
            frac6.setB((frac1.den * frac2.den));
            frac6.setA(((frac1.num * frac2.den) - (frac2.num * frac1.den)));
            return frac6;
        }


        // int - obj
        public static Fraction operator -(int n, Fraction frac2)
        {
            Fraction frac6 = new Fraction();
            frac6.setB(frac2.den);
            frac6.setA((frac2.den * n) - frac2.num);
            return frac6;
        }

        // obj - int
        public static Fraction operator -(Fraction frac2, int n) { 

            Fraction frac6 = new Fraction();
            frac6.setB((frac2.den * n));
            frac6.setA(((frac2.num * n) - (frac2.num * n)));
            return frac6;
        }

        public static Fraction operator +(Fraction frac2, int n)
        {

            Fraction frac6 = new Fraction();
            frac6.setB(frac2.den);
            frac6.setA(frac2.num + frac2.den);
            return frac6;
        }

        public static Fraction operator ++(Fraction a)
        {
            Fraction frac6 = new Fraction();
            frac6.setB(a.den);
            frac6.setA(a.num + a.den);
            return frac6;
        }
        public static bool operator ==(Fraction a,Fraction b)
        {
            double x = a.num / a.den;
            double y = b.num / b.den;

            if (x == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Fraction a,Fraction b)
        {
            double x = a.num / a.den;
            double y = b.num / b.den;

            if (x == y)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool Equals(Fraction a)
        {
            double x = num/den;
            double y = a.num/a.den;

            if (x == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
