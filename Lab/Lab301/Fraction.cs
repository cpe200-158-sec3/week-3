using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
    class Fraction
    {
        public int _numer;
        public int _denom;

        private static int _count;

        public int Numer
        {
            get { return _numer; }
            set { _numer = value; }
        }

        public int Denom
        {
            get
            {
                return _denom;
            }

            set
            {
                _denom = value;
            }
        }

        public static int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public Fraction()
        {
            _numer = 0;
            _denom = 1;
            _count++;
        }

        public Fraction(int x)
        {
            _numer = x;
            _denom = 1;
            _count++;
        }

        public Fraction(int x, int y)
        {
           
            _numer = x / Fraction.GCD(x, y);
            _denom = y / Fraction.GCD(x, y);
            _count++;
        }

        public Fraction(Fraction f1)
        {
            _numer = f1._numer / Fraction.GCD(_numer, _denom);
            _denom = f1._numer / Fraction.GCD(_numer, _denom);
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            return new Fraction(f1._numer * f2._denom + f1._denom * f2._numer, f1._denom * f2._denom);
        }

        public static Fraction operator +(Fraction f1, int f2)
        {
            return new Fraction((f2 * f1.Denom) + f1.Numer, f1.Denom);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            return new Fraction(f1._numer * f2._denom - f1._denom * f2._numer, f1._denom * f2._denom);
        }

        public static Fraction operator -(int f1, Fraction f2)
        {
            return new Fraction((f1 * f2.Denom) - f2.Numer, f2.Denom);
        }

        public static Fraction operator ++(Fraction f1)
        {
            return new Fraction(f1._numer + f1._denom, f1._denom);
        }

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            return (f1._numer == f2._numer && f1._denom == f2._denom);
        }


        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return (f1._numer != f2._numer && f1._denom != f2._denom);
        }

        public bool Equals(Fraction f1)
        {
            if (this._numer == f1._numer && this._denom == f1._denom)
                return true;

            else return false;

        }

        public static int GCD(double w, double u) {
            int GCD = 1;
            for (int cd = 1; (cd <= w) && (cd <= u); cd++) {
                if ((w % cd == 0) && (u % cd == 0)) {
                    GCD = cd;
                }
            }
            return GCD;
        }

        public void setValue(int x, int y)
        {
            _numer = x;
            if (y == 0) { y = 1; }
            _denom = y;

        }

        public static float ans(float a, float b)
        {

            return a / b;
        }

        public override string ToString()
        {
            string s = "[Rational: " + _numer + "/" + _denom + "], value=" + ans(_numer, _denom) + "]";
            return s;
        }
    }
}
