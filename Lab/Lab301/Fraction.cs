using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
    class Fraction
    {
        //propertise
        public static int Count;
        
        public int numer
        {
            get;
            set; 
        }
        public int denom
        {
            get; 
            set; 
        }

        //Constructer
        public Fraction()
        {
            denom = 1;
            numer = 0;
            Count++;
            
        }
        public Fraction(int n)
        {
            numer = n;
            denom = 1;
            Count++;
            
        }
        public Fraction(int n, int d)
        {
            denom = d;
            numer = n;
            Count++;
           
        }

        public Fraction(Fraction a)
        {
            numer = a.numer;
            denom = a.denom;
            Count++;
            
        }

        //Operator overload
        public static Fraction operator +(Fraction a,Fraction b)
        {
           
            return new Fraction((a.numer * b.denom) + (b.numer * a.denom),(a.denom*b.denom));
        }

        public static Fraction operator +(Fraction a, int b)
        {
            return new Fraction((a.numer * 1) + (b * a.denom), (a.denom * 1));
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction((a.numer * b.denom) - (b.numer * a.denom), (a.denom * b.denom));
        }
        public static Fraction operator -(int a, Fraction b)
        {
        
            return new Fraction((a * b.denom) - (b.numer * 1), (1 * b.denom));
        }

        public static Fraction operator ++(Fraction a)
        {
            a.numer = (a.numer * 1) + (1 * a.denom);
            return a;
        }

        public static Boolean operator ==(Fraction x, Fraction y)
        {
            return (x.numer == y.numer && x.denom == y.denom);
        }

        public static Boolean operator !=(Fraction x, Fraction y)
        {
            return (x.numer != y.numer || x.denom != y.denom);
        }

        public override bool Equals(object obj)
        {
            var item = obj as Fraction;

            if (item == null)
            {
                return false;
            }

            Fraction a = obj as Fraction;
            return (a.numer == this.numer && a.denom == this.denom);
        }
        public bool Equals(Fraction a)
        {
            return (a.numer == this.numer && a.denom == this.denom);
        }

        public override int GetHashCode()
        {
            return numer ^ denom;
        }

        //setvalue method
        public void setValue(int n, int d)
        {
            numer = n;
            if (d == 0)
            {
                d = 1;
            }

            denom = d;
        }

        //GCD
        public static int GCD(int a,int b)
        {
            int Remainder;
            if (a < b)
            {
                Remainder = a;
                a = b;
                b = Remainder;
            }
            while (b > 0)
            {
                Remainder = a % b;
                a = b;
                b = Remainder;
            }

            return a;
        }

        //Simplify fraction
        public void ReduceFraction(ref int n,ref int m)
        {
            int k = GCD(n, m);
            n /= k;
            m /= k;
        }

        public override string ToString()
        {
            int Rnumer = numer;
            int Rdenom = denom;
            ReduceFraction(ref Rnumer, ref Rdenom);
            double result = Convert.ToDouble(numer) / Convert.ToDouble(denom);
            return string.Format("[Rational: {0}/{1}], value={2}]",Rnumer ,Rdenom, result);
        }
    }
}
