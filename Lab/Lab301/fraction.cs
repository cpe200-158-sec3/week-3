using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
    class Fraction
    {
        private double num, denom;

        public double Numer
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }

        public double Denomer
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

        private static int collector;

        public static int Count
        {
            get 
            {
                return collector;
            }
        }

        public Fraction()
        {
            this.Numer = 0;
            this.Denomer = 1;
            collector++;
        }

        public Fraction(double num)
        {
            this.Numer = num;
            this.Denomer = 1;
            collector++;
        }

        public Fraction(double num, double denom)
        {
            this.Numer = num;
            this.Denomer = denom;
            collector++;
        }

        public Fraction(Fraction x)
        {
            this.Numer = x.num;
            this.Denomer = x.denom;
        }

        public static Fraction operator +(Fraction f, int x)
        {
            return new Fraction((f.Numer + (f.Denomer * x)), (f.Denomer));
        }
        public static Fraction operator +( int x, Fraction f)
        {
            return new Fraction((f.Numer + (f.Denomer * x)), (f.Denomer));
        }
        public static Fraction operator -(Fraction f, int x)
        {
            return new Fraction(( f.Numer - (f.Denomer * x)), (f.Denomer));
        }
        public static Fraction operator -(int x, Fraction f)
        {
            return new Fraction(((f.Denomer * x) - f.Numer), (f.Denomer));
        }

        //fraction operator (f,f) and ++ --(f)
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            return new Fraction((f1.Numer * f2.Denomer) + (f2.Numer * f1.Denomer), (f1.Denomer * f2.Denomer));
        }
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            return new Fraction((f1.Numer * f2.Denomer) - (f2.Numer * f1.Denomer), (f1.Denomer * f2.Denomer));
        }
        public static Fraction operator ++(Fraction f)
        {
            return new Fraction((f.Numer + f.Denomer) , f.Denomer);
        }
        public static Fraction operator --(Fraction f)
        {
            return new Fraction((f.Numer - f.Denomer), f.Denomer);
        }

        //bool check
        public static bool operator ==(Fraction f1, Fraction f2)
        {
            return (f1.Numer / f1.Denomer == f2.Numer / f2.Denomer);
        }
        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return (f1.Numer / f1.Denomer != f2.Numer / f2.Denomer);
        }
        public bool Equals(Fraction f)
        {
            return (this.num / this.denom == f.Numer / f.Denomer);
        }
        
        // set value
        public void setValue(int a, int b)
        {
            this.num = a;
            if (b == 0)
                this.denom = 1;
            else
                this.denom = b;
        }

        //gcd ตัวหารร่วมมาก cd = common divisor
        public static int GCD(double a, double b)
        {
            int gcd = 1;
            for (int cd = 1; (cd <= a) && (cd <= b); cd++)
            {
                if((a % cd == 0) && (b % cd == 0))
                {
                    gcd = cd;
                }
            }
            return gcd;
        }

        public override string ToString()
        {
            string x = "[Rational: " + this.Numer + "/" + this.Denomer + "], value=" + (this.Numer / this.Denomer) + "]";
            return x;
        }
    }
}
