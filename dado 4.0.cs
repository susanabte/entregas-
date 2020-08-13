using System;
					
public class Program

{
	public static void Main()
	{
       Random aleatorio = new Random();
       int d1 = 0, d2 = 0, vida = 3, total = 0, totald = 0, turno = 0;
       string continuar = "s";

        while (continuar == "s" ) 
        {
            turno +=1;

            if (turno % 2 ==0)
            {
                vida -= 1;
            }
            if (vida == 0)
            {
                Console.WriteLine("total: " + total);
                Console.WriteLine("Mi Vida: " + vida);
                 Console.WriteLine("perdiste");
                break;
            }


            if (turno % 3 == 0)
            {
                Console.WriteLine("%%%%%%% Se tiran dos dados, si son dobles +1 vida %%%%%%%");
                d1 = aleatorio.Next(1,7);
                total= (d1 + total);
                Console.WriteLine(d1);
                d2 = aleatorio.Next(1,7);
                total= (d2 + total);
                Console.WriteLine(d2);
                Console.WriteLine("total: " + total);
                Console.WriteLine("Mi Vida: " + vida);

                if (d1 == d2){       
                    vida +=1;
                    Console.WriteLine("+1 vida");
                }
            }else {
                d1 = aleatorio.Next(1,7);
                total= (d1 + total);
                Console.WriteLine(d1);
                Console.WriteLine("total: " + total);
                Console.WriteLine("Mi Vida: " + vida);
            }
            if (total > 100)
            {
                Console.WriteLine("total: " + total);
                Console.WriteLine("ganaste!!!! :D :");
                Console.WriteLine("Mi Vida: " + vida);
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