using System;
					
public class Program

{
	public static void Main()
	
{
 
    Random aleatorio = new Random();
    int carta = 0, total = 0, ronda = 0;
    string continuar = "s";

    while (continuar == "s" && total < 22) {
            if (ronda == 0){
                carta = aleatorio.Next(1,10);
                Console.WriteLine(carta);
                total= (carta + total);
                carta = aleatorio.Next(1,10);
                Console.WriteLine(carta);
                total = (carta + total);
                Console.WriteLine("total:" + total);
                
                Console.WriteLine("si quiere una carta presionan S, si no presiona N:");
                continuar = Console.ReadLine();
            }
           else {
               carta = aleatorio.Next(1,10);
               Console.WriteLine(carta);
               total = (carta + total);
               Console.WriteLine("total:" + total);
              
              if (total > 21){
                  Console.WriteLine("no puede continuar");
              }

              else if (total == 21) {
                Console.WriteLine("ganaste!!!! :D :");
                continuar = "N";
                  
              }
              else {
                Console.WriteLine("si quiere una carta presionan S, si no presiona N:");
                continuar = Console.ReadLine();
            
                }
            }
    ronda = (ronda + 1);
}
}
}