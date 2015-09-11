using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
  
 namespace Lab301  
 {  
     class Fraction  
     {   
       public static int Count;  
   
         public int numer  
         {  
            get ;  
            set ;  
         }  
         public int denom  
         {  
            get ;  
            set ;  
        }  
   
         public Fraction()  
         {  
             numer = 0;  
             denom = 1;  
             Count++;  
         }  
        public Fraction(int a)  
         {  
             numer = a;  
           denom = 1;  
            Count++;  
         }  
   
         public Fraction(int a, int b)  
         {  
            numer = a;  
            denom = b;  
            Count++;  
         }  
   
        public Fraction(Fraction a)  
         {  
             this.numer = a.numer;  
            this.denom = a.denom;  
             Count++;  
         }  
   
         public static Fraction operator +(Fraction a,Fraction b)  
         {  
             return new Fraction((a.numer * b.denom) + (b.numer * a.denom),(a.denom*b.denom));  
        }  
         public static Fraction operator +(Fraction a, int b)  
         {  
             return new Fraction((a.numer * 1) + (b * a.denom),(a.denom * 1));  
         }  
         public static Fraction operator -(Fraction a,Fraction b)  
        {  
             return new Fraction((a.numer * b.denom) - (b.numer * a.denom),(a.denom * b.denom));  
        }  
        public static Fraction operator -(int a, Fraction b)  
         {  
             return new Fraction((a * b.denom) - (b.numer * 1),(1* b.denom));  
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
             if(item == null)  
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
  	         return numer^denom;  
         }  
   
         public void setValue(int a, int b)  
         {  
             numer = a;  
             if (b == 0)  
             {  
                 b = 1;  
             }  
   
            denom = b;  
         }  
   
         public static int GCD(int a, int b)  
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
   
         public void Reduce(ref int a,ref int b)  
         {  
             int x = GCD(a, b);  
             a /= x;  
             b /= x;  
         }  
   
         public override string ToString()  
         {  
             int Rnumer = numer;  
             int Rdenom = denom;  
             Reduce(ref Rnumer, ref Rdenom);  
           double result = Convert.ToDouble(numer) / Convert.ToDouble(denom);  
            return string.Format("[Rational: {0}/{1}, value={2}]", Rnumer , Rdenom,result);  
        }  
    }
}  
