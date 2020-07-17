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
        Console.WriteLine("Tarifa A, Cuota Moderada= 3.400**");
    }
    else if (2* minimo <= salario && salario < 5 * minimo )
    {
        Console.WriteLine("Tarifa B, Cuota Moderada= 13.500**");
    }
    else if (salario >= 5 * minimo)
    {
        Console.WriteLine("Tarifa C, Cuota Moderada= 35.600**");  
    }
    }
    
}