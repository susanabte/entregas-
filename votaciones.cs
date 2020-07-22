sing System;
					
public class Program

{
	public static void Main()
	
{
    console.WriteLine("ingrese los siguientes datos de la votacion:");

    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int blancos = int.Parse(Console.ReadLine());
    int anulados = int.Parse(Console.ReadLine());
    int n = int.Parse(Console.ReadLine());
    int p = int.Parse(Console.ReadLine());

    int vt = a + b + blancos + anulados;
    double an = 0.3 +(a+b);
    double pn = n * (p/102);
    double ab = pn - vt;

    if (anulados < an || (a + b) > blanocs && ab < vt); {
    console.WriteLine("exito en las votaciones:");
    
      if (a > b)
      {
        console.WriteLine("gana el partido 1:");
      }
       else 
       console.WriteLine("gana el partido 2:");
    }
    else {
    console.WriteLine("se deben repetir las votaciones");
    }
}
}



