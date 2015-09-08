using System;

namespace Lab301
{

	public class Fraction
	{
		private double Numer;
		private double Denom;
		private static int count;



		public Fraction ()
		{
			Numer = 0;
			Denom = 1;
			count++;
		}
		public Fraction (double a)
		{
			Numer = a;
			Denom = 1;
			count++;
		}
		public Fraction (double a, double b)
		{
			Numer = a/Fraction.GCD(a, b);
			Denom = b / Fraction.GCD (a, b);
			count++;
		}
		public Fraction (Fraction a)
		{
			Numer = a.Numerator;
			Denom = a.Denominator;
		}

		public static int Count
		{
			get 
			{
				return count;
			}
		}

		public double Numerator
		{
			get 
			{
				return Numer;
			}
			set
			{ 
				Numer = value;
			}
		}
		public double Denominator
		{
			get 
			{
				return Denom;
			}
			set 
			{
				Denom = value;
			}
		}

		public static Fraction operator +(Fraction a, int b)
		{
			return new Fraction (a.Numerator + (b*a.Denominator), a.Denominator);
		}
		public static Fraction operator +(Fraction a, Fraction b)
		{
			return new Fraction ((a.Numerator * b.Denominator) + (a.Denominator*b.Numerator),(a.Denominator * b.Denominator));
		}
		public static Fraction operator -(Fraction a, Fraction b)
		{
			return new Fraction ((a.Numerator * b.Denominator) - (a.Denominator*b.Numerator),(a.Denominator * b.Denominator));
		}
		public static Fraction operator -(int a, Fraction b)
		{
			return new Fraction (a*b.Denominator - (b.Numerator), b.Denominator);
		}
		public static Fraction operator * (Fraction a ,Fraction b)
		{
			return new Fraction ((a.Numerator * b.Numerator),(a.Denominator * b.Denominator));
		}
		public static Fraction operator / (Fraction a ,Fraction b)
		{
			return new Fraction ((a.Numerator * b.Denominator),(a.Denominator * b.Numerator));
		}
		public static bool operator == (Fraction a ,Fraction b)
		{
			double result1;
			double result2;
			result1 = a.Numerator / (a.Denominator*1.0);
			result2 = b.Numerator / (b.Denominator*1.0);
			if(result1 == result2)
			{
				return true;		
			}
			return false;
		}
		public bool Equals (Fraction a)
		{
			double result1;
			double result2;
			result1 = a.Numerator / (a.Denominator*1.0);
			result2 = Numer / Denom;
			if(result1 == result2)
			{
				return true;		
			}
			return false;
		}
		public static bool operator != (Fraction a ,Fraction b)
		{
			if(a == b)
			{
				return false;		
			}
			return true;
		}
		public static Fraction operator ++ (Fraction a)
		{
			return new Fraction ((a.Numerator + a.Denominator),a.Denominator);
		}
		public void setValue(double a, double b)
		{
			Numer = a;
			if (b == 0) 
			{
				Denom = 1;
			} 
			else 
			{
				
				Denom = b;
			}
		}
		public static int GCD(double a,double b)
		{
			int GCD = 0;
			for (int gcd = 1; (gcd <= a) && (gcd <= b); gcd++) 
			{
				if ((a % gcd == 0) && (b % gcd == 0)) {
					GCD = gcd;
				}
			}
			return GCD;
		}
		public override string ToString ()
		{
			return string.Format ("[Rational: {0}/{1}], value={2}]", Numerator, Denominator , Numerator/Denominator);
		}
	}
}