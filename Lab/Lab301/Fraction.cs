using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
    class Fraction
    {
        private double Numer;
        private double Denom;
       // private int Count;

        //default constructor
        public Fraction()
        {
            this.Numer = 0;
            this.Denom = 1;
            _callcount++;
        }

        //constructor has one parameter
        public Fraction(double numerator)
        {
            this.Numer = numerator;
            this.Denom = 1;
            _callcount++;
        }

        //constructor have two parameters
        public Fraction(double numerator, double denominator)
        {
            double a = Fraction.GCD(numerator, denominator);
            this.Numer = numerator/a;
            this.Denom = denominator/a;
            _callcount++;
        }

        public Fraction(Fraction a)
        {
            this.Numer = a.Numer;
            this.Denom = a.Denom;
        }


        //get set numerator
        public double Numerator
        {
            get { return Numer; }
            set { Numer = value; }
        }

        //get set demominator
        public double Denominator
        {
            get { return Denom; }
            set
            {
                if (value == 0)
                {
                    throw new Exception("0 denominator");
                }

                Denom = value;
            }
        }
        private static int _callcount = 0;

        public static int Count
        {
            get { return _callcount; }
        }

        //method set value
        public void setValue(int a, int b) {

           this.Numer = a;
            if (b == 0)
            {
                this.Denom = 1;
            }
            else
            {
                this.Denom = b;
            }
        }

        //
        public static int GCD(double num,double denom)
        {
            //i is value
            int gcd = 1;
            for (int i = 1; (i <= num) && (i <= denom); i++)
            {
                if ((num % i == 0) && (denom % i == 0))
                {
                    gcd = i;
                }
            }
            return gcd;
        }

        //Fraction plus
        public static Fraction operator +(Fraction a, Fraction b)
        {
            //double r1 = (a.Numerator * b.Denominator) + (b.Numerator * a.Denominator);
            //double r2 = a.Denominator * b.Denominator;
            //double plus=r1/r2;
            //return new Fraction(r1,r2);

             return new Fraction(a.Numerator * b.Denominator + b.Numerator * a.Denominator,
              a.Denominator * b.Denominator);
            
        }
        // operator plus int and fraction
        public static Fraction operator +(int a,Fraction b) {
            return new Fraction(a * b.Denominator + b.Numerator, b.Denominator);
        }

        //operator fraction plus one
        public static Fraction operator ++( Fraction b)
        {
            return new Fraction(1* b.Denominator + b.Numerator, b.Denominator);
        }
        // operator plus fraction and int
        public static Fraction operator +(Fraction a, int b)
        {
            return new Fraction(b * a.Denominator + a.Numerator , a.Denominator);
        }
        
        //Fraction minus fraction and fraction
        public static Fraction operator -(Fraction a, Fraction b)
        {
            
                return new Fraction(a.Numer * b.Denominator - b.Numerator * a.Denominator,
                a.Denominator * b.Denominator);
            
        }

        // operator minus int and fraction
        public static Fraction operator -(int a, Fraction b)
        {
            return new Fraction(a * b.Denominator - b.Numerator, b.Denominator);
        }

        // operator minus fraction and int
        public static Fraction operator -(Fraction a, int b)
        {
            return new Fraction(b * a.Denominator - a.Numerator, a.Denominator);
        }

        //Fraction multiple
        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Numerator , a.Denominator * b.Denominator);
        }

        //Fraction 
        public static Fraction operator /(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
        }

        //Compare fraction

        //equal
       /* public static bool operator ==(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Denominator) == new Fraction(b.Numerator * a.Denominator);
        }

        //not equal
        public static bool operator !=(Fraction a, Fraction b)
        {
            return (!(a == b));
        }

        public static bool operator >(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Denominator) > new Fraction(b.Numerator * a.Denominator);
        }

        public static bool operator >=(Fraction a, Fraction b)
        {
            return (!(a < b));
        }

        public static bool operator <(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Denominator) < new Fraction(b.Numerator * a.Denominator);
        }

        public static bool operator <=(Fraction a, Fraction b)
        {
            return (!(a > b));
        }*/

        public override string ToString()
        {//[Rational: 0/1], value=0]
            return "[Rational: "+Numer+"/"+Denom+"], value="+Numer/Denom+"]";
        }
    }

}
