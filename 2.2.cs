using System;using System;
					
public class Program

{
	public static void Main()
	
{
		//ejercicio 2
           double t = 3.61;
           double a = 33.69;
		
		//calculado c
		  double c = 180 - (90 + a);
		
		//calculado z
		double zRad = t*Math.Sin(90);;
        double zDregress = zRad;

		//calculado y
		double yRad = t*Math.Sin(a);;
        double yDregress = yRad;
		
		Console.WriteLine("c =" + c);
		Console.WriteLine("z =" + zDregress);
		Console.WriteLine("y =" + yDregress);
	}
}

