using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
    class fraction
    {
        private double num;
        private double denum;
        private static int count = 0;

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
        public static int Count
        {
            get
            {
                return count;
            }
        }
        public fraction()
        {
            this.Num = 0;
            this.Denum = 1;
            count++;
        }
        public fraction(double num)
        {
            this.Num = num;
            this.Denum = 1;
            count++;
        }
        public fraction(double num, double denum)
        {
            this.Num = num / fraction.GCD(num, denum);
            this.Denum = denum / fraction.GCD(num, denum);
            count++;
        }
        public fraction(fraction f)
        {
            this.Num = f.Num;
            this.Denum = f.Denum;
        }
        public static fraction operator +(fraction r1, fraction r2)
        {
            return new fraction((r1.num * r2.denum) + (r2.num * r1.denum), r1.denum * r2.denum);
        }
        public static fraction operator +(fraction r1, double x)
        {
            return new fraction(r1.num + (r1.denum * x), r1.denum * x);
        }
        public static fraction operator ++(fraction r1)
        {
            return new fraction(r1.num + r1.denum, r1.denum);
        }
        public static fraction operator -(fraction r1, fraction r2)
        {
            return new fraction((r1.num * r2.denum) - (r2.num * r1.denum), r1.denum * r2.denum);
        }
        public static fraction operator -(double x, fraction r1)
        {
            return new fraction((x * r1.denum) - r1.num, r1.denum);
        }
        public static bool operator ==(fraction r1, fraction r2)
        {
            if ((r1.num * r2.denum == r2.num * r1.denum) && (r1.denum == r2.denum))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(fraction r1, fraction r2)
        {
            if ((r1.num * r2.denum != r2.num * r1.denum))
            {
                return true;
            }
            return false;
        }
        public bool Equals(fraction f)
        {
            return (this.num / this.denum == f.num / f.denum);
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
        public void setValue(int f1, int f2)
        {
            this.num = f1;
            if (f2 == 0)
            {
                this.denum = 1;
            }
            else
            {
                this.denum = f2;
            }
        }
        public override string ToString()
        {
            return "[Rational: " + num + "/" + denum + "], " + "value=" + num / denum + "]";


        }
    }
}
