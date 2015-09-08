using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab301
{
    class Fraction
    {
        private int Numer;
        private int Demo;
        public static int Count;

        //Constructor
        public Fraction()
        {
            Numer = 0;
            Demo = 1;
            Count++;
        }

        public Fraction(Fraction a)
        {
            Numer = a.Numer;
            Demo = a.Demo;
            Count++;
        }

        public Fraction(int num)
        {
            Numer = num;
            Demo = 1;
            Count++;
        }

        public Fraction(int num, int dom)
        {
            Numer = num;
            Demo = dom;
            Count++;
        }


        //Method
        public void setValue(int num,int dom)
        {
            Numer = num;
            if (Numer == num)
            { Demo = 1; }
            else { Demo = dom; }
        }

        public static int GCD(int num, int dem)
        {
            return dem == 0 ? num : GCD(dem, num % dem);
        }

        private double Div()
		{
			double num = Numer;
			double dem = Demo;
			return num / dem;
		}

    //Properties
    public int Number
		{
			get{ return Numer;  }
			set{ Numer = value; }
		}
		public int Denom
		{
			get{ return Numer; }
			set{ Numer = value; }
		}

        //+ overload
        public static Fraction operator +(Fraction frac, int num )
        {
            Fraction result = new Fraction();
            result.Numer = (num * frac.Demo) + frac.Numer;
            result.Demo = (1) * frac.Demo;
            return result;
        }

        public static Fraction operator +(Fraction frac1 , Fraction frac2)
        {
            Fraction result = new Fraction();
            result.Numer = (frac1.Numer * frac2.Demo) + (frac2.Numer * frac1.Demo);
            result.Demo = frac1.Demo * frac2.Demo;
            return result;
        }

        public static Fraction operator ++(Fraction frac)
        {
            frac.Numer = frac.Numer + (1 * frac.Demo);
            return frac;
        }

        //- overlaod
        public static Fraction operator -(Fraction frac1, Fraction frac2)
        {
            Fraction result = new Fraction();
            result.Numer = (frac1.Numer * frac2.Demo) - (frac2.Numer * frac1.Demo);
            result.Demo = frac1.Demo * frac2.Demo;
            return result;
        }

        public static Fraction operator -(int num , Fraction frac )
        {
             Fraction result = new Fraction();
             result.Numer = (num * frac.Demo) - frac.Numer;
             result.Demo = (1) * frac.Demo;
             return result;
        }

        // equal overload
        public static bool operator ==(Fraction frac1, Fraction frac2)
 		{
			return (frac1.Numer == frac2.Numer && frac1.Demo == frac2.Demo);
		}
		public static bool operator !=(Fraction frac1, Fraction frac2)
		{
			return (frac1.Numer != frac2.Numer || frac1.Demo != frac2.Demo);
        }

        //fix caution (Equals ~ GetHashCode)
        public override int GetHashCode()
		{
			return Numer ^ Demo;
        }

        public bool Equals(Fraction frac)
		{
			// If parameter is null return false:
			if ((object)frac == null)
			{
				return false;
			}

			// Return true if the fields match:
			return (Numer == frac.Numer) && (Demo == frac.Demo);
        }

        public override bool Equals(object obj)
		{
			// If parameter is null return false.
			if (obj == null)
			{
				return false;
			}

			// If parameter cannot be cast to Point return false.
			Fraction frac = obj as Fraction;
			if ((System.Object)frac == null)
			{
				return false;
			}

			// Return true if the fields match:
			return (Demo == frac.Demo) && (Numer == frac.Numer);
		}
        // output
        public override string ToString()
		{
			return string.Format("[Rational: {0}/{1}], value={2}]", Numer/GCD(Numer, Demo), Demo / GCD(Numer, Demo), Div());
		}


    }
}
