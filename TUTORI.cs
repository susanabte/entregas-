using System;
					
public class Program

{
	public static void Main()
	
{ 
    int n1 = 0, n2 = 0, op = 0, total = 0,f;
    Random aleatorio = new Random();
    
    while (op <= 3 ) {
      if (op == 3)
  
        {
            Console.WriteLine("eres una maquina, fuera");break;
        }
    n1 = aleatorio.Next(1,10);
    n2 = aleatorio.Next(1,10);
    total = n1 + n2;
    Console.WriteLine("cuanto es " + (n1 + "+" + n2));
    f = int.Parse(Console.ReadLine());
            
         if (f == total)
        {
            Console.WriteLine("puedes continuar ");
            op = 4;
        }
        else{
          Console.WriteLine("respuesta incorrecta");
          op +=1;
        }
        
    }
}
}