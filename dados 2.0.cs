using System;
					
public class Program

{
	public static void Main()
	
{
    Random aleatorio = new Random();
    int d1 = 0, total = 0, contador = 0, ronda = 0;
    string continuar = "s";

    
    while (continuar == "s" && total < 100) 
    {
        d1 = aleatorio.Next(1,13);
        total= (d1 + total);
        Console.WriteLine (d1);
		Console.WriteLine("total:" + total);
		ronda +=1;
        
        {
            if (contador == 1)
        {
            if (d1 == 10)
            {
                contador += 1; 
            }
			if (d1 !=10)
			{
				contador = 0;
			}
        }
        if (d1 == 12 )
        {
            contador += 1; 
        }
        if (ronda > 3)
        
        if (d1%2 != 0)
        {
            total = 0;
            Console.WriteLine("perdiste");
            continuar = "N";
        }
        }

       if(total >= 100 || contador == 2)
		{ 
		Console.WriteLine("ganaste!!!! :D :");
        continuar = "n";
        }
        
        if( continuar == "s") 
        
        {
        Console.WriteLine("si quiere tirar el dado presionan s, si no presiona n:");
        continuar = Console.ReadLine();
        }
    }
}
}
