using System;using System;
					
public class Program

{
	public static void Main()
	
{
		//ejercio 3
        double c = 56.31;
        double z = 3;
		
		//calculado a
		double a = 180 - (90 + c);
		
		//calculado y
		double yRad = z*Math.Sin(90);
        //double yDregress = yRad * 180 / Math.PI;
	
		//calculando t
		double t = Math.Sqrt((y*y)+(z*z));
        //double tDregress = tRad;
		
		Console.WriteLine("a =" + a);
		Console.WriteLine("t =" + t);
		Console.WriteLine("y =" + yRad);
	}
}