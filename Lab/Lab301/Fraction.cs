using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
        public class Fraction
    {
        private double Numer;
        private double Denom;
        private static int count;

        public Fraction()
        {
           Numer = 0;
           Denom = 1;
           count++;
        }
        public Fraction(double n)
        {
            Numer = n;
            Denom = 1;
            count++;
        }
        public Fraction(double n, double d)
        {
            Numer = n / Fraction.GCD(n, d);
            Denom = d / Fraction.GCD(n, d);
            count++;
        }
        public Fraction(Fraction n)
        {
           Numer = n.Numerator;
           Denom = n.Denominator;
        }
        
        public static double Count
        {
           get
            {
                return count;
            }
        }

        public double Numerator
        {
            get
            {
                return this.Numer;
            }
            set
            {
                this.Numer = value;
            }
        }
        public double Denominator
        {
            get
            {
                return this.Denom;
            }
            set
            {
                if (value == 0)
                {
                    throw new Exception("0 denominator");
                }

                this.Denom = value;
            }
        }

        public override string ToString()
        {
           return string.Format("[Rational: {0}/{1}], value={2}]", Numerator, Denominator, Numerator / Denominator);
        }

        public void setValue(double a, double b)
        {
            Numer = a;
            if (b == 0)
            {
                Denom = 1;
            }
            else
            {
                Denom = b;
            }
        }
        public static int GCD(double a, double b)
        {
            int GCD = 0;
            for (int gcd = 1; (gcd <= a) && (gcd <= b); gcd++)
            {
                if ((a % gcd == 0) && (b % gcd == 0))
                {
                    GCD = gcd;
                }
            }
            return GCD;
        }

        public static Fraction operator +(Fraction a, int b)
        {
            return new Fraction(a.Numerator + (b* a.Denominator), a.Denominator);
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction((a.Numerator* b.Denominator) + (a.Denominator* b.Numerator), (a.Denominator* b.Denominator));
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction((a.Numerator* b.Denominator) - (a.Denominator* b.Numerator), (a.Denominator* b.Denominator));
        }
        public static Fraction operator -(int a, Fraction b)
        {
            return new Fraction(a* b.Denominator - (b.Numerator), b.Denominator);
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction((a.Numerator* b.Numerator), (a.Denominator* b.Denominator));
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            return new Fraction((a.Numerator* b.Denominator), (a.Denominator* b.Numerator));
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            double result1;
            double result2;
            result1 = a.Numerator / (a.Denominator* 1.0);
            result2 = b.Numerator / (b.Denominator* 1.0);
            if (result1 == result2)
            {
                return true;
            }
            return false;
        }
        public bool Equals(Fraction a)
        {
            double result1;
            double result2;
            result1 = a.Numerator / (a.Denominator* 1.0);
            result2 = Numer / Denom;
            if (result1 == result2)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            if (a == b)
            {
                return false;
            }
            return true;
        }
        public static Fraction operator ++(Fraction a)
        {
            return new Fraction((a.Numerator + a.Denominator), a.Denominator);
        }

    }
}
