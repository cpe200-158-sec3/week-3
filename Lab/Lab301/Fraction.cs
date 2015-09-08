using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
    class Fraction
    {
        private double _numer, _denom;
        public double Numer
        {
            get { return _numer; }
            set { _numer = value; }
        }

        public double Denom
        {
            get { return _denom; }
            set { _denom = value; }
        }

        public static int Count = 0;

        public Fraction()
        {
            this.Numer = 0;
            this.Denom = 1;
            Count++;
        }

        public Fraction(double number)
        {
            this.Numer = number;
            this.Denom = 1;
            Count++;
        }

        public Fraction(double number, double denom)
        {
            this.Numer = number / GCD(number, denom);
            this.Denom = denom / GCD(number, denom);
            Count++;
        }

        public Fraction(Fraction frac)
        {
            this.Numer = frac.Numer;
            this.Denom = frac.Denom;
        }
        public static Fraction operator +(Fraction frac1, Fraction frac2)
        {
            return new Fraction((frac1.Numer * frac2.Denom) + (frac1.Denom * frac2.Numer), frac1.Denom * frac2.Denom);
        }

        public static Fraction operator -(Fraction frac1, Fraction frac2)
        {
            return new Fraction((frac1.Numer * frac2.Denom) - (frac1.Denom * frac2.Numer), frac1.Denom * frac2.Denom);
        }

        public static Fraction operator ++(Fraction frac)
        {
            return new Fraction(frac.Numer + (1 * frac.Denom), frac.Denom);
        }

        public static Fraction operator +(Fraction frac, int num)
        {
            return new Fraction(frac.Numer + (frac.Denom * num), frac.Denom);
        }

        public static Fraction operator -(int den, Fraction frac)
        {
            return new Fraction((frac.Denom * den) - frac.Numer, frac.Denom);
        }

        public static bool operator ==(Fraction frac1, Fraction frac2)
        {
            return (frac1.Numer / frac1.Denom == frac2.Numer / frac2.Denom);
        }

        public static bool operator !=(Fraction frac1, Fraction frac2)
        {
            return (frac1.Numer / frac1.Denom != frac2.Numer / frac2.Denom);
        }

        public bool Equals(Fraction frac)
        {
            return (this.Numer / this.Denom == frac.Numer / frac.Denom);
        }

        public static int GCD(double num, double den)
        {
            int gcd = 1;
            for(int check = 1;check <= num && check <=den;check++)
            {
                if(num % check == 0)
                {
                    if(den % check == 0)
                    {
                        gcd = check;
                    }
                }
            }
            return gcd;
        }
        public void setValue(int num, int den)
        {
            this.Numer = num;
            if (den != 0)
                this.Denom = den;
            else
                this.Denom = 1;
        }

        public override string ToString()
        {
            string s = "[Rational: " + this.Numer + "/" + this.Denom + "], value=" + (this.Numer / this.Denom) + "]";
            return s;
        }
    }
}
