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
        public static int count=0;

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
        public Fraction(double numer , double denom)
        {
            double x = Fraction.GCD(numer, denom);
            Numer = numer /x;
            Denom = denom /x;
            count++;
        }
        public static Fraction operator +(Fraction x1, Fraction x2)
        {
            return new Fraction((x1.Numer*x2.Denom)+(x1.Denom*x2.Numer) , x2.Denom *x1.denom);
        }
        public static Fraction operator +(Fraction x1, double s)
        {
            s = s * x1.Denom;
            return new Fraction(x1.Numer+s, x1.Denom);
        }
        public static Fraction operator +(double s, Fraction x1)
        {
            s = s * x1.Denom;
            return new Fraction(x1.Numer +s, x1.Denom);
        }
        public static Fraction operator -(Fraction x1, Fraction x2)
        {
            return new Fraction((x1.Numer * x2.Denom) - (x1.Denom * x2.Numer), x2.Denom * x1.denom);
        }
        public static Fraction operator -(Fraction x1, double s)
        {
            s = s * x1.Denom;
            return new Fraction(x1.Numer - s, x1.Denom);
        }
        public static Fraction operator -(double s, Fraction x1)
        {
            s = s * x1.Denom;
            return new Fraction(s - x1.Numer , x1.Denom);
        }
        public Fraction(Fraction x)
        {
            this.Numer = x.Numer;
            this.Denom = x.Denom;
        }
        public static Fraction operator ++(Fraction x)
        {      
            return new Fraction(x.Numer + x.Denom, x.Denom);
        }

        public bool Equals(Fraction x)
        {
           if(Numer / Denom == x.Numer /x.Denom)
            {
                return true;
            }
           else
            {
                return false;
            }
        }
        public void setValue(double numer, double denom)
        {
            Numer = numer;
            if (denom == 0)
            {
                Denom = 1;   
            }
            else
            {
                Denom = denom;
            }
            
        }
        public static int Count
        {
            get
            {
                return count;
            }
        }
        public static bool operator ==(Fraction x1, Fraction x2)
        {
            return (x1.Numer == x2.Numer && x1.Denom == x2.Denom);
        }
        public static bool operator !=(Fraction x1, Fraction x2)
        {
            return (x1.Numer != x2.Numer || x1.Denom != x2.Denom);
        }

        public static double GCD (double x1,double x2)
        {
            int gcd = 1;
            for (int i = 1; (x1 >= i) && (i <= x2); i++)
            {
               if ((x1 % i == 0) && (x2 % i == 0))
                         {
                            gcd = i;
                         }
            }
            return gcd;
        }
        public override string ToString()
        {
          //double value = (Numer / Denom);
          string s = "[Rational: " + Numer + "/" + Denom + "], value=" + (Numer / Denom) + "]";
          return s;
        }
    }
}
