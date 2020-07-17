using System;
					
public class Program

{
	public static void Main()
	
{
    float salario;
    float minimo = 877803;
    Console.WriteLine("escribir su salario mensual");
    salario = float.Parse(Console.ReadLine());

    if (salario < 2 * minimo)
    {
        Console.WriteLine("Tarifa A");
    }
    else if (2* minimo <= salario && salario < 4 * minimo )
    {
        Console.WriteLine("Tarifa B");
    }
    else if (salario >= 4 * minimo)
    {
        Console.WriteLine("Tarifa C");  
    }
    }
    
}
