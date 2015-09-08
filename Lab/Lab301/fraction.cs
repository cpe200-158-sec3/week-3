using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
    class Fraction
    {
        private double numer;
        private double denom;
        private static int count = 0;

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

        public static int Count
        {
            get
            {
                return count;
            }
        }

        public Fraction()
        {
            Numer = 0;
            Denom = 1;
            count++;

        }
        public Fraction(double numer)
        {
            Numer = numer;
            Denom = 1;
            count++;
        }

        public Fraction(double numer, double denom)
        {
            Numer = numer / Fraction.GCD(numer, denom);
            Denom = denom / Fraction.GCD(numer, denom);
            count++;
        }

        public Fraction(Fraction a)
        {
            Numer = a.Numer;
            Denom = a.Denom;
        }

        public static Fraction operator +(Fraction a, int b)
        {
            return new Fraction((a.Numer + (a.Denom * b)), (a.Denom));
        }

        public static Fraction operator +(int b, Fraction a)
        {
            return new Fraction((a.Numer + (a.Denom * b)), (a.Denom));
        }

        public static Fraction operator +(Fraction a1, Fraction a2)
        {
            return new Fraction((a1.Numer * a2.Denom) + (a2.Numer * a1.Denom), (a1.Denom * a2.Denom));
        }

        public static Fraction operator -(Fraction a, int b)
        {
            return new Fraction((a.Numer - (a.Denom * b)), (a.Denom));
        }

        public static Fraction operator -(int b, Fraction a)
        {
            return new Fraction(((a.Denom * b) - a.Numer), (a.Denom));
        }

        public static Fraction operator -(Fraction a1, Fraction a2)
        {
            return new Fraction((a1.Numer * a2.Denom) - (a2.Numer * a1.Denom), (a1.Denom * a2.Denom));
        }


        public static Fraction operator ++(Fraction a)
        {
            return new Fraction((a.Numer + a.Denom), a.Denom);
        }

        public static Fraction operator --(Fraction a)
        {
            return new Fraction((a.Numer - a.Denom), a.Denom);
        }


        public static bool operator ==(Fraction a1, Fraction a2)
        {
            return (a1.Numer == a2.Numer && a1.Denom == a2.Denom);
        }
        public static bool operator !=(Fraction a1, Fraction a2)
        {
            return (a1.Numer != a2.Numer || a1.Denom != a2.Denom);
        }
        public bool Equals(Fraction a)
        {
            return (Numer / denom == a.Numer / a.Denom);
        }


        public void setValue(int x, int y)
        {
            numer = x;
            if (y == 0)
                denom = 1;
            else
                denom = y;
        }

        public static int GCD(double x, double y)
        {
            int gcd = 1;
            for (int z = 1; (z <= x) && (z <= y); z++)
            {
                if ((x % z == 0) && (y % z == 0))
                {
                    gcd = z;
                }
            }
            return gcd;
        }
        public override string ToString()
        {
            string x = "[Rational: " + this.Numer + "/" + this.Denom + "], value=" + (this.Numer / this.Denom) + "]";
            return x;
        }

    }
}