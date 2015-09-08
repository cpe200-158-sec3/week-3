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
            this.Numer = 0;
            this.Denom = 1;
            count++;
        }
        public Fraction(double numer)
        {
            this.Numer = numer;
            this.Denom = 1;
            count++;
        }
        public Fraction(double numer, double denom)
        {
            this.Numer = numer / Fraction.GCD(numer, denom);
            this.Denom = denom / Fraction.GCD(numer, denom);
            count++;
        }
        public Fraction(Fraction f)
        {
            this.Numer = f.Numer;
            this.Denom = f.Denom;
        }
        public static Fraction operator +(Fraction f1,Fraction f2)
        {
            return new Fraction((f1.Numer*f2.Denom+f2.Numer*f1.Denom) , (f1.Denom*f2.Denom));
        }
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            return new Fraction((f1.Numer * f2.Denom - f2.Numer * f1.Denom) , (f1.Denom * f2.Denom));
        }
        public static Fraction operator ++(Fraction f)
        {
            return new Fraction((f.Numer + f.Denom) , f.Denom);
        }

        public static Fraction operator +(Fraction f, int x)
        {
            return new Fraction((f.Numer + (f.Denom * x)), (f.Denom));
        }
        public static Fraction operator +(int x, Fraction f)
        {
            return new Fraction((f.Numer + (f.Denom * x)), (f.Denom));
        }
        public static Fraction operator -(int x, Fraction f)
        {
            return new Fraction(((f.Denom * x) - f.Numer), (f.Denom));
        }
        public static Fraction operator -(Fraction f, int x)
        {
            return new Fraction((f.Numer - (f.Denom * x)), (f.Denom));
        }

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            return (f1.Numer / f1.Denom == f2.Numer / f2.Denom);
        }
        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return (f1.Numer / f1.Denom != f2.Numer / f2.Denom);
        }
        public bool Equals(Fraction f)
        {
            return (this.numer / this.denom == f.numer / f.denom);
        }
        public void setValue(int f1, int f2)
        {
            this.numer = f1;
            if(f2 == 0)
            {
                this.denom = 1;
            }
            else 
            {
                this.denom = f2;
            }
        }
        public static int GCD(double a, double b)
        {
            int gcd = 1;
            for (int x = 1; (x <= a) && (x <= b); x++)
            {
                if ((a % x == 0) && (b % x == 0))
                {
                    gcd = x;
                }
            }
            return gcd;
        }

        public override string ToString()
        {
            string s = "[Rational: " + Numer + "/" + Denom + "], value=" + (Numer / Denom) + "]";
            return s;
        }
    }
}
