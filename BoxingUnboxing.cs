using System;

public static void Main(string []args)
	{
		int i = 123;      // a value type
		object o = i;     // boxing--> putting value data type into an object. It is done implicitly.
		int j = (int)o;   // unboxing--> putting object into a value data type. It is done explicitly.
		// Both are computationally expensive tasks.
	}