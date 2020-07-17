using System;using System;
					
public class Program

{
	public static void Main()
	
{
    float altura, peso, imc;
    
    Console.WriteLine("escribir su altura en CM");
    altura = Float.Parse(console.RaedLine());
    Console.WriteLine("escribir su peso en kg");
    peso = loat.Parse(console.RaedLine());

    imc peso / ((altura/100)*(altura/100));
    
    if (imc < 16)
          Console.WriteLine("Delgadez severa");
    else if (imc < 16.99)
        Console.WriteLine("Delgadez moderada");
    else if (imc < 18.49)
    Console.WriteLine("Delgadez aceptable");
    else if (imc < 24.99)
    Console.WriteLine("peso normal");
    else if (imc < 29.99)
    Console.WriteLine("sobre peso");
     else if (imc < 34.99)
      Console.WriteLine("obesidad");
}
}