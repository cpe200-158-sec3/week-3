using System;

namespace Lab301
{
	public class Fraction
	{
		private int number,denom;
		public static int Count;
		double value;
		public int Number
		{
			get{ return number;  }
			set{ number = value; }
		}
		public int Denom
		{
			get{ return denom; }
			set{ denom = value; }
		}
		private double YU()
		{
			double a = number;
			double b = denom;
			return a / b;
		}
		public void setValue(int a,int b)
		{
			number = a;
			if (b == 0) {
				denom = 1;
			} else {
				denom = b;
			}
		}
		public static int GCD(int a,int b)
		{
			return b == 0 ? a : GCD(b, a % b);
		}

		public Fraction ()
		{
			Number = 0;
			Denom = 1;
			Count++;
		}
		public Fraction (int a)
		{
			Number = a;
			Denom = 1;
			Count++;
		}
		public Fraction(Fraction a)
		{
			this.Number = a.Number;
			this.Denom = a.Denom;
			Count++;
		}
		public Fraction(int a,int b)
		{
			Number = a;
			Denom = b;
			Count++;
		}
		public static Fraction operator+ (Fraction a,Fraction b)
		{
			Fraction result = new Fraction();
			result.Number = (a.Number * b.Denom) + (b.Number * a.Denom);
			result.Denom = a.Denom * b.Denom;
			return result;
		}
		public static Fraction operator- (Fraction a,Fraction b)
		{
			Fraction result = new Fraction();
			result.Number = (a.Number * b.Denom) - (b.Number * a.Denom);
			result.Denom = a.Denom * b.Denom;
			return result;
		}
		public static Fraction operator* (Fraction a,Fraction b)
		{
			Fraction result = new Fraction();
			result.Number = a.Number * b.Number;
			result.Denom = a.Denom * b.Denom;
			return result;
		}
		public static Fraction operator/ (Fraction a,Fraction b)
		{
			Fraction result = new Fraction();
			result.Number = a.Number + b.Number;
			result.Denom = a.Denom * b.Denom;
			return result;
		}
		public static Fraction operator ++ (Fraction a)
		{
			a.Number = a.Number + (1 * a.Denom);

			return a;
		}
		public static Fraction operator + (Fraction a, int j)
		{
			Fraction result = new Fraction();
			result.Number = (j * a.Denom) + a.Number;
			result.Denom = (1) * a.Denom;
			return result;
		}
		public static Fraction operator - ( int j,Fraction a)
		{
			Fraction result = new Fraction();
			result.Number = (j * a.Denom) - a.Number;
			result.Denom = (1) * a.Denom;
			return result;
		}
		public override bool Equals (object obj)
		{
			// If parameter is null return false.
			if (obj == null)
			{
				return false;
			}

			// If parameter cannot be cast to Point return false.
			Fraction p = obj as Fraction;
			if ((System.Object)p == null)
			{
				return false;
			}

			// Return true if the fields match:
			return (Denom == p.Denom) && (Number == p.Number);
		}
		public bool Equals(Fraction p)
		{
			// If parameter is null return false:
			if ((object)p == null)
			{
				return false;
			}

			// Return true if the fields match:
			return (Number == p.Number) && (Denom == p.Denom);
		}
		public override int GetHashCode()
		{
			return Number ^ Denom;
		}

		public static bool operator == (Fraction a,Fraction b)
		{
			return (a.Number == b.Number && a.Denom == b.Denom);
		}
		public static bool operator != (Fraction a,Fraction b)
		{
			return (a.Number != b.Number || a.Denom != b.Denom);
		}
		public override string ToString ()
		{
			return string.Format ("[Rational: {0}/{1}], value={2}]", Number/GCD(Number,Denom),Denom/GCD(Number,Denom),YU());
		}
	}
}

