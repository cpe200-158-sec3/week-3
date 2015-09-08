using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
    class  Fraction
    {
        public double Num;
        public double Denum;
        public static int Count ;



        public double num
        {
            get 
            {
                return Num; 
            }
            set 
            { 
                Num = value; 
            }
        }
        public double denum
        {
            get 
            { 
                return Denum; 
            }
            set 
            { 
                Denum = value; 
            }
        }
        public static int count
        {
            get 
            { 
                return Count; 
            }
        }
       


        public Fraction()
        {
            Num = 0;
            Denum = 1;
            Count++;
        }
        public Fraction(double num)
        {
            Num = num;
            Denum = 1;
            Count++;

        }

        public Fraction (double num,double denum)
        {
            Num = num / Fraction.GCD(num, denum);
            Denum = denum / Fraction.GCD(num,denum);
            Count++;
        }

        public void setValue(int in1,int in2)
        {
            Num = in1;
                      if (in2 == 0)
                            {
                Denum = 1;
                            }
                        else 
            {
                Denum = in2;
                            }
        }

       public static int GCD(double in1,double in2 )
        {
            int gcd=0 ;
                        for (int x = 1; (x <= in1) && (x <= in2); x++)
                            {
                                if ((in1 % x == 0) && (in2 % x == 0))
                                    {
                   gcd = x;
                                    }
                           }
                      return gcd;
        }




        public static Fraction operator +(Fraction f1, Fraction f2)
         {
             return new Fraction((f1.num* f2.denum+f2.num* f1.denum) , (f1.denum* f2.denum));
         }
         public static Fraction operator -(Fraction f1, Fraction f2)
         {
             return new Fraction((f1.num* f2.denum - f2.num* f1.denum) , (f1.denum* f2.denum));
         }
         public static Fraction operator ++(Fraction f)
         {
             return new Fraction((f.num + f.denum) , f.denum);
         }
 
         public static Fraction operator +(Fraction f, int x)
         {
             return new Fraction((f.num + (f.denum* x)), (f.denum));
         }
         public static Fraction operator +(int x, Fraction f)
         {
             return new Fraction((f.num + (f.denum* x)), (f.denum));
         }
         public static Fraction operator -(int x, Fraction f)
         {
             return new Fraction(((f.denum* x) - f.num), (f.denum));
         }
         public static Fraction operator -(Fraction f, int x)
         {
             return new Fraction((f.num - (f.denum* x)), (f.denum));
         }
 
         public static bool operator ==(Fraction f1, Fraction f2)
         {
             return (f1.num / f1.denum == f2.num / f2.denum);
         }
         public static bool operator !=(Fraction f1, Fraction f2)
         {
             return (f1.num / f1.denum != f2.num / f2.denum);
         }
        public bool Equals(Fraction f)
        {
            return (this.num / this.denum == f.num / f.denum);
        }












        public override string ToString()
        {
            string s = "[Rational: " + Num + "/" + Denum + "], value=" + (Num / Denum) + "]";
            return s;
        }



}
}
