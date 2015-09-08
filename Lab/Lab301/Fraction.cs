using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
        class Fraction
        {
            private double numer, denom;
            private static int _callcount = 0;
            private double a;

        public static int Count
        {
            get { return _callcount; }
        }

        public double Numer
            {
                get
                {
                    return numer;
                }
                set
                {
                    numer = value;
                }
            }
            public double Denom
            {
                get
                {
                    return denom;
                }
                set
                {
                    denom = value;
                }
            }

            public Fraction()
            {
                this.Numer = 0;
                this.Denom = 1;
                _callcount++;
            }
            public Fraction(double numer)
            {
                this.Numer = numer;
                this.Denom = 1;
                _callcount++;
            }
            public Fraction(double numer, double denom)
            {
                this.Numer = numer / Fraction.GCD(numer, denom);
                this.Denom = denom / Fraction.GCD(numer, denom);
                _callcount++;
            }
            public Fraction(Fraction a)
            {
                this.Numer = a.Numer;
                this.Denom = a.Denom;
            }
            public void setValue(int a1, int a2)
            {
                this.numer = a1;
                if (a2 == 0)
                {
                    this.denom = 1;
                }
                else
                {
                    this.denom = a2;
                }
            }
            public static int GCD(double b1, double b2)
            {
                int gcd = 1;
                for (int x = 1; (x <= b1) && (x <= b2); x++)
                {
                    if ((b1 % x == 0) && (b2 % x == 0))
                    {
                        gcd = x;
                    }
                }
                return gcd;
            }

        public static Fraction operator +(Fraction b1, Fraction b2)
        {
            return new Fraction((b1.Numer * b2.Denom + b2.Numer * b1.Denom), (b1.Denom * b2.Denom));
        }
        public static Fraction operator -(Fraction b1, Fraction b2)
        {
            return new Fraction((b1.Numer * b2.Denom - b2.Numer * b1.Denom), (b1.Denom * b2.Denom));
        }
        public static Fraction operator ++(Fraction a)
        {
            return new Fraction((a.Numer + a.Denom), a.Denom);
        }

        public static Fraction operator +(Fraction a, int x)
        {
            return new Fraction((a.Numer + (a.Denom * x)), (a.Denom));
        }
        public static Fraction operator +(int x, Fraction a)
        {
            return new Fraction((a.Numer + (a.Denom * x)), (a.Denom));
        }
        public static Fraction operator -(int x, Fraction a)
        {
            return new Fraction(((a.Denom * x) - a.Numer), (a.Denom));
        }
        public static Fraction operator -(Fraction a, int x)
        {
            return new Fraction((a.Numer - (a.Denom * x)), (a.Denom));
        }


        public override string ToString()
            {
                string s = "[Rational: " + Numer + "/" + Denom + "], value=" + (Numer / Denom) + "]";
                return s;
            }
      }
}
