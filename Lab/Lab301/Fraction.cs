using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
    class Fraction
    {
        //private double num;
        //private double den;
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

        public Fraction(){
            numer = 0;
            denom = 1;
            Count++;
        }
        public Fraction(int n, int d)
        {
            numer = n; denom = d;
            Count++;
        }

        public Fraction(Fraction a) {
            numer = a.numer;
            denom = a.denom;
            Count++;
        }

        public Fraction(int n)
        {
            numer = n;
            denom = 1;
            Count++;
        }

        public static Fraction operator +(Fraction x,Fraction y){

            return new Fraction((x.numer * y.denom) + (y.numer * x.denom), (x.denom * y.denom));
       }
        public static Fraction operator -(Fraction x, Fraction y){
            
            return new Fraction((x.numer * y.denom) - (y.numer * x.denom), (x.denom * y.denom));
        }

        public static Fraction operator +(Fraction x, int y){

            return new Fraction((x.numer * 1) + (y * x.denom), (x.denom * 1));
    }
        public static Fraction operator -(int x, Fraction y)
        {

            return new Fraction((x * y.denom) - (y.numer * 1), (1 * y.denom));
        }

        public static Fraction operator ++(Fraction x){

            x.numer = (x.numer * 1) + (1 * x.denom);
            return x;
        }
        public static bool operator == (Fraction x,Fraction y)
        {
            return (x.numer == y.numer && x.denom == y.denom);
        }
        public static bool operator !=(Fraction x, Fraction y)
        {
            return(x.numer!=y.numer||x.denom!=y.denom);
        }
        public override string ToString(){
            int Knumer = numer;
            int Kdenom = denom;
            ReduceFraction(ref Knumer, ref Kdenom);
            double result = Convert.ToDouble(numer) / Convert.ToDouble(denom);
            return string.Format("[Rational: {0}/{1}, value={2}]", Knumer,Kdenom,result );
        }
        public override bool Equals(object obj)
        {
            var item = obj as Fraction;

            if (item == null)
            {
                return false;
            }

            Fraction k = obj as Fraction;
            return (k.numer == this.numer && k.denom == this.denom);
        }
        public bool Equals(Fraction k)
        {
            return (k.numer == this.numer && k.denom == this.denom);
        }

        public override int GetHashCode()
        {
            return numer ^ denom;
        }

        //## Methods
        //- setValue: set fraction value
        public void setValue(int n,int d)
        {
            numer = n;
            if(d==0)
            {
                d = 1;
            }
            
            denom = d;
        }
        //- GCD: calculate Greatest Common Divisor of two integers (static)
        public static int GCD(int a,int b)
        {
            int Remainder;

            while (b != 0)
            {
                Remainder = a % b;
                a = b;
                b = Remainder;
            }

            return a;
         }
        public void ReduceFraction(ref int l, ref int o)
        {
            int p = GCD(l, o);
            l /= p;
            o /= p;
        }
    }

}

        