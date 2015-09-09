//Name Patsamon Boonchai 570611023 SEC 003
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
        private static int temp = 0;
        private double a;

        public static int Count
        {
            get
            {
                return temp;
            }
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
            temp++;
        }
        public Fraction(double numer)
        {
            this.Numer = numer;
            this.Denom = 1;
            temp++;
        }
        public Fraction(double numer, double denom)
        {
            this.Numer = numer / Fraction.GCD(numer, denom);
            this.Denom = denom / Fraction.GCD(numer, denom);
            temp++;
        }
        public Fraction(Fraction a)
        {
            this.Numer = a.Numer;
            this.Denom = a.Denom;
        }
        public void setValue(int num1, int num2)
        {
            this.numer = num1;
            if (num2 == 0)
            {
                this.denom = 1;
            }
            else
            {
                this.denom = num2;
            }
        }
        public static int GCD(double a1, double a2)
        {
            int gcd = 1;
            for (int i = 1; (i <= a1) && (i <= a2); i++)
            {
                if ((a1 % i == 0) && (a2 % i == 0))
                {
                    gcd = i;
                }
            }
            return gcd;
        }


        public static bool operator ==(Fraction b1, Fraction b2)
        {
            return (b1.Numer / b1.Denom == b2.Numer / b2.Denom);
        }
        public static bool operator !=(Fraction b1, Fraction b2)
        {
            return (b1.Numer / b1.Denom != b2.Numer / b2.Denom);
        }
        public bool Equals(Fraction b1)
        {
            return (numer / denom == b1.Numer / b1.Denom);
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
            string tmp = "[Rational:" + Numer + "/" + Denom + "], value=" + (Numer / Denom) + "]";
            return tmp;
        }
    }
}



