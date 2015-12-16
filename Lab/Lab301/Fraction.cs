using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
    class Fraction
    {
        private double numeral;
        private double denominator;
        private static int count;


        public double Numeral
        {
            get
            {
                return numeral;
            }
            set
            {
                numeral = value;
            }
        }
        public double Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                denominator = value;
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
            numeral = 0;
            denominator = 1;
            count++;
        }
        public Fraction(double numeral)
        {
            this.numeral = numeral;
            denominator = 1;
            count++;
        }
        public Fraction(double numeral, double denominator)
        {

            this.numeral = numeral / Fraction.GCD(numeral, denominator);
            this.denominator = denominator / Fraction.GCD(numeral, denominator);
            count++;
        }
        public Fraction(Fraction a)
        {
            numeral = a.Numeral;
            denominator = a.Denominator;
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            return new Fraction((f1.Numeral * f2.Denominator) + (f2.Numeral * f1.Denominator), (f1.Denominator * f2.Denominator));

        }
        public static Fraction operator +(Fraction f, int n)
        {
            return new Fraction(f.Numeral + (f.Denominator * n), f.Denominator);

        }
        public static Fraction operator +(int n, Fraction f)
        {
            return new Fraction(f.Numeral + (f.Denominator * n), f.Denominator);

        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            return new Fraction((f1.Numeral * f2.Denominator) - (f2.Numeral * f1.Denominator), (f1.Denominator * f2.Denominator));
        }
        public static Fraction operator -(int n, Fraction f)
        {
            return new Fraction((n * f.Denominator) - f.Numeral, f.Denominator);
        }


        public static Fraction operator ++(Fraction f1)
        {
            Fraction n = new Fraction(f1.Numeral + f1.Denominator, f1.Denominator);

            return n;

        }

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            double F1 = (f1.Numeral / f1.Denominator);
            double F2 = (f2.Numeral / f2.Denominator);

            if (F1 == F2)
            {
                return true;

            }
            return false;
        }
        public static bool operator !=(Fraction f1, Fraction f2)
        {
            double F1 = (f1.Numeral / f1.Denominator);
            double F2 = (f2.Numeral / f2.Denominator);

            if (F1 != F2)
            {
                return true;

            }
            return false;
        }

        public bool Equals(Fraction f)
        {
            double F1 = (numeral / denominator);
            double F2 = (f.Numeral / f.Denominator);

            if (F1 == F2)
            {
                return true;

            }
            return false;

        }

        public void setValue(double num, double denom)
        {
            numeral = num;

            if (denom == 0)
            {
                denominator = 1;
            }
            else
            {
                denominator = denom;

            }

        }


        public static int GCD(double x, double y)
        {
            {
                int GCD = 0;
                for (int gcd = 1; (gcd <= x) && (gcd <= y); gcd++)
                {
                    if ((x % gcd == 0) && (y % gcd == 0))
                    {
                        GCD = gcd;
                    }
                }
                return GCD;

            }
        }




        public override string ToString()
        {
            return string.Format("[Rational: {0}/{1}], value={2}]", Numeral, Denominator, Numeral / Denominator);
        }

    }
}