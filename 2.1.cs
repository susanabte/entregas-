using System;using System;
					
public class Program

{
	public static void Main()
	
{
	public static void Main()
{
        //primer ejercicio
        double y = 2;
        double z = 3;
        
        //calcular a
        double aRad = Math.Atan(y/z);
        double aDregress = aRad * 180 / Math.PI;
        Console.WriteLine("a:" + aDregress);

        //calcular c
        double cRad = Math.Atan(z/y);
        double cDregress = cRad * 180 / Math.PI;
        Console.WriteLine("c:" + cDregress);

        //hipotenusa
        double YSq = y * y;
        double ZSq = z * z;
        double hipo = Math.Sqrt(YSq + ZSq);
        Console.WriteLine("t:" + hipo);

    }
}