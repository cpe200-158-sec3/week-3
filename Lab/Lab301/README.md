# Implement the Fraction class according to the following requirements:

//Natthapong Burakitphachai 570611011 Sec003

## Propeties:
- Numer: Numerator
- Denom: Denominator (default=1, cannot be 0)
- Count: counting #objects of this class (static)
Note: Numerator and Denominator have to in the minimal form.
      See r3 and r6.

## Constructors:
- Fraction (): default constructor
- Fraction (Fraction a): copy constructor
- Fraction (numerator, denominator)
note: increment the Count property when an object is created

## Methods
- setValue: set fraction value
- GCD: calculate Greatest Common Divisor of two integers (static)

## Operator Overloading:
many many operators need to be overloaded!!! 

## Question?
1. Is the number of Fraction objects equal to the 'new' keywords used
   in the 'main' methods? How come?
	- The number of object is different (higher objects counted than actual create in "main"). because the operator created new additional
	  object in the process. so  
	  

2. Are the result, r3 and r7, in case#1 and case#2 the same? Why?
	- the result of r7 is the same but the result of r3 is different. The numbers of objects that have been also created. because ...

	  : in case#1 [r3=4/3], the r7 object come from creating the new Fraction object base on the object r3 that goes throught 
				   parameter constructor (so in this case#1 it has more object created) and not directly equal to r3 object. Causes both cases to go on different process and 
				   given different output result. 
	  : in case#2 [r3=1/3], the r7 object is directly equal to the value of r3 without creating the new Fraction object.
				   so this case have fewer object created.
	  

## Expected Output:

***** 3 Fraction objects have been created *****
***** 8 Fraction objects have been created *****
***** 12 Fraction objects have been created *****
[Rational: 0/1], value=0]
[Rational: 2/1], value=2]
[Rational: 1/3], value=0.333333333333333]
[Rational: 2/1], value=2]
[Rational: 5/3], value=1.66666666666667]
[Rational: 4/1], value=4]
[Rational: 4/3], value=1.33333333333333]
[Rational: 8/1], value=8]
[Rational: 6/5], value=1.2]
True
True
False
[Rational: 10/1], value=10]
***** 12 Fraction objects have been created *****
GCD of 3650 and 360: 10
GCD of 3600 and 360: 360

