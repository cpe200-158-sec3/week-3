using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
    class Fraction
    {
        private double _numer, _denom;
        public double Numer
        {
            get { return _numer; }
            set { _numer = value; }
        }
        public double Denom
        {
            get { return _denom; }
            set { _denom = value; }
        }
        private static int _count = 0;
        public static int Count
        {
            get { return _count; }
        }
        public Fraction()
        {
            this.Numer = 0;
            this.Denom = 1;
            _count++;
        }
        public Fraction(double numer)
        {
            this.Numer = numer;
            this.Denom = 1;
            _count++;
        }
        public Fraction(double numer, double denom)
        {
            this.Numer = numer;
            this.Denom = denom;
            _count++;
        }
        public Fraction(Fraction f)
        {
            this.Numer = f.Numer;
            this.Denom = f.Denom;
        }
        public static Fraction operator +(Fraction f1,Fraction f2)
        {
            return new Fraction((f1.Numer*f2.Denom+f2.Numer*f1.Denom)/(f1.Denom*f2.Denom));
        }
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            return new Fraction((f1.Numer * f2.Denom - f2.Numer * f1.Denom) / (f1.Denom * f2.Denom));
        }
        public static Fraction operator ++(Fraction f)
        {
            return new Fraction((f.Numer + f.Denom)/f.Denom);
        }

        public static Fraction operator +(Fraction f,int x)
        {
            return new Fraction((f.Numer + (f.Denom * x)) / (f.Denom));
        }
        public static Fraction operator +(int x, Fraction f)
        {
            return new Fraction((f.Numer + (f.Denom * x)) / (f.Denom));
        }
        public static Fraction operator -(int x, Fraction f)
        {
            return new Fraction(((f.Denom * x) - f.Numer) / (f.Denom));
        }
        public static Fraction operator -(Fraction f, int x)
        {
            return new Fraction((f.Numer - (f.Denom * x)) / (f.Denom));
        }

        //public static Fraction operator =(Fraction f)
        //{
        //    return new Fraction();
        //}
        public override string ToString()
        {
            string s = "[Rational: " + this.Numer + "/" + this.Denom + "], value=" + (this.Numer / this.Denom) + "]";
            return s;
        }
    }
}
