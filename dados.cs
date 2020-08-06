using System;
					
public class Program

{
	public static void Main()
	
{
    Random aleatorio = new Random();
    int d1 = 0, d2 = 0, total = 0, contador = 0, totald = 0, turno = 0;
    string continuar = "s";

    while (continuar == "s" ) 
    {
        d1 = aleatorio.Next(1,7);
        total= (d1 + total);
        Console.WriteLine(d1);
        d2 = aleatorio.Next(1,7);
        total= (d2 + total);
        Console.WriteLine(d2);
         Console.WriteLine("total:" + total);
		turno += 1;

        if (d1 == 1 && d2 == 1)
        {
            total = 0;
            Console.WriteLine("perdiste");
            continuar = "N";
        }
        else if (d1 == d2)
        {
            totald = (totald + 1);
        }
        else 
        {
            totald = 0;
        }
        // se pone el porcentaje
        if ( (d1+d2)> 6)
        {
         contador += 1; 
        }
        if (total >= 100 || totald == 3) 
        {
        Console.WriteLine("ganaste!!!! :D :");
        continuar = "n";
        }
        if( continuar == "s") 
        {
        Console.WriteLine("si quiere una dado presionan S, si no presiona N:");
        continuar = Console.ReadLine();
        }
    }
	double k = (contador * 100) / turno;
Console.WriteLine(k + "% porcentaje de turnos donde la suma entre los dados fue superior a 6 ");
}
}

