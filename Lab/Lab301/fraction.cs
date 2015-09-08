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
        private static int count;

        public double Numer {
            get {
                return numer;
            }
            set {
                numer = value;
            }
        }

        public double Denom {
            get {
                return denom;
            }
            set {
                denom = value;
            }
        }

        public static int Count {
            get {
                return count;
            }
            set {
                count = value;
            }
        }

        public Fraction() {
            Numer = 0;
            Denom = 1;
            Count++;
        }

        public Fraction(double n) {
            Numer = n;
            Denom = 1;
            Count++;
        }

        public Fraction(double n, double d)
        {
            Numer = n / Fraction.GCD(n, d);
            Denom = d / Fraction.GCD(n, d);
            Count++;
        }

        public Fraction(Fraction x) {
            numer = x.Numer / Fraction.GCD(numer,denom);
            denom = x.Denom / Fraction.GCD(numer,denom);
        }

        public static Fraction operator +(Fraction r1, Fraction r2) {
            return new Fraction(r1.numer * r2.denom + r1.denom * r2.numer, r1.denom * r2.denom);
            
        }

        public static Fraction operator -(Fraction r2, Fraction r3) {
            return new Fraction(r2.numer * r3.denom - r2.denom * r3.numer, r2.denom * r3.denom);
        }

        public static Fraction operator +(int a, Fraction r3)
        {
            return new Fraction(a*r3.denom+r3.numer , r3.denom);
        }

        public static Fraction operator +(Fraction r3 , int a)
        {
            return new Fraction(a * r3.denom + r3.numer, r3.denom);
        }

        public static Fraction operator -(int a, Fraction r3)
        {
            return new Fraction(a * r3.denom - r3.numer, r3.denom);
        }

        public static Fraction operator -(Fraction r3, int a)
        {
            return new Fraction(r3.numer-r3.denom*a, r3.denom);
        }

        public static Fraction operator ++(Fraction x)
        {
            return new Fraction(x.numer + x.denom, x.denom);
        }

        public static Fraction operator --(Fraction x)
        {
            return new Fraction(x.numer - x.denom, x.denom);
        }

        public bool Equals(Fraction x) {
            return numer / denom == numer / denom;
        }

        public static bool operator ==(Fraction f1 , Fraction f2) {
            return f1.numer / f1.denom == f2.numer / f2.denom;
        }

        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return f1.numer / f1.denom != f2.numer / f2.denom;
        }

        public void setValue(double s , double v) {
            numer = s;
            
            if (v == 0)
            {
                denom = 1;
            }
            else {
                denom = v;
            }
        }

        public static double GCD(double w, double u) {
            int GCD = 1;
            for (int cd = 1; (cd <= w) && (cd <= u); cd++) {
                if ((w % cd == 0) && (u % cd == 0)) {
                    GCD = cd;
                }
            }
            return GCD;
        }

        public override string ToString()
        {
            return "[Rational: " + numer + "/" + denom + "], value=" + numer / denom + "]"; //[Rational: 0/1], value=0]
        }
    }
}
