using System;
					
public class Program

{
	public static void Main()
	
{
    // inicio de variables
    double salario,cotizacion,pension,eps,salarioa,srm;
    double minimo = 877803;
	double arl = 0;
	double deduccion;
    int dependencia;
    int ndr = 0; 
    

    //RyW console
    Console.WriteLine("escribir su salario mensual");
    salario = float.Parse(Console.ReadLine());
    Console.WriteLine("escribir 1 si es dependiente y 2 si es independiente");
    dependencia = int.Parse(Console.ReadLine());

    if (dependencia == 2 )
    {
        Console.WriteLine("escribir su nivel de riesgo del 1 al 5");
        ndr= int.Parse(Console.ReadLine());
    }
    
    //funciones

    cotizacion = (40 * salario)/100;
    if (cotizacion < minimo)
    {
        cotizacion = minimo;
    }

    if (dependencia == 1)
    {
        pension = (4 * cotizacion)/100;
        eps = (4 * cotizacion)/100;
        deduccion = (eps + pension);
    }
    else 
    {
        pension = (16 * cotizacion)/100;
        eps = (12.5 * cotizacion)/100;
        
        
        switch (ndr)
        {
          case 1:
              Console.WriteLine("nivel de riesgo 1");
              arl = (0.522 * cotizacion)/100;
              break;
          case 2: 
                arl = (1.044 * cotizacion)/100;
              break;
          case 3:
               arl =(2.436 * cotizacion)/100;
              break;
          case 4:
              arl = (4.350 * cotizacion)/100;
              break;
          case 5:
               arl = (6.960 * cotizacion)/100;
              break;  
      }
   }
        
        deduccion = (eps + pension + arl);
    }

    srm = salario - deduccion;

    //salidas

    Console.WriteLine("salario real mensual = " + srm);

    if (dependencia == 1)
    {
    salarioa = ((srm * 12) + salario);
    }
    else
    {
        salarioa = srm * 12;
    }
    Console.WriteLine("salario anual = " + salarioa);
    }
}