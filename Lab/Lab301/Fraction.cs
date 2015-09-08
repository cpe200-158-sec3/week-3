using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
    class Fraction
    {
        private double num;
        private double denum;
        private static int count = 0;

        public static double Count
        {
            get
            {
                return count;
            }
        }    
        public double Num
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
        public double Denum
        {
            get
            {
                return denum;
            }
            set
            {
                denum = value;
            }
        }
        public void setValue(int x, int y)
        {
            num = x;
            if (y == 0)
            {
                denum = 1;
            }
            else
            {
                denum = y;
            }
        }       
        public static Fraction operator +(Fraction r1, Fraction r2)
        {
            return new Fraction((r1.num * r2.denum) + (r2.num * r1.denum), r1.denum * r2.denum);
        }
        public static Fraction operator +(Fraction r1, double x)
        {
            return new Fraction(r1.num + (r1.denum * x), r1.denum * x);
        }
        public static Fraction operator ++(Fraction r1)
        {
            return new Fraction(r1.num + r1.denum,r1.denum);
        }
        public static Fraction operator -(Fraction r1, Fraction r2)
        {
            return new Fraction((r1.num * r2.denum) - (r2.num * r1.denum), r1.denum * r2.denum);
        }
        public static Fraction operator -(double x, Fraction r1)
        {
            return new Fraction((x * r1.denum) - r1.num, r1.denum);
        }
        public static bool operator ==(Fraction r1, Fraction r2)
        {
            if ((r1.num * r2.denum == r2.num * r1.denum) && (r1.denum == r2.denum))
            {
                return true;
            } 
            return false;
        }
        public static bool operator !=(Fraction r1, Fraction r2)
        {
            if ((r1.num * r2.denum != r2.num * r1.denum))
            {
                return true;
            }
            return false;
        }
        public bool Equals(Fraction r1)
        {
            if ((r1.num / r1.denum) != (this.num / this.denum))
            {
                return false;
            }
            return true;
        }
        public static int GCD(double x, double y)
        {            
            int c = 1;
            int a = 1;
            while ((a <= x) && (a <= y))
            {
                if ((x % a == 0) && (y % a == 0))
                {
                    c = a;
                }
                a++;
            }
            return c;
        }
        public Fraction()
        {
            num = 0;
            denum = 1;
            count++;
        }
        public Fraction(double num)
        {
            this.num = num;
            denum = 1;
            count++;
        }
        public Fraction(Fraction r1)
        {
            this.num = r1.num;
            this.denum = r1.denum;
        }
        public Fraction(double num, double denum)
        {
            this.num = num / Fraction.GCD(num, denum);
            this.denum = denum / Fraction.GCD(num, denum);
            count++;
        }
        public override string ToString()
        {          
            return "[Rational: " + num + "/" + denum + "], " + "value=" + num / denum + "]";
        }
    }
}
