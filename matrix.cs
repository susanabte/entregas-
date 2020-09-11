using System;

public class Class1
{
	public Class1()
	{
        Random random = new Random();
        string[] valores = { "-", "-", "O", "X" };
        int n = 10;
        int m = 15;

        string[,] tablero = new string[n, m];
        string[,] salida = new string[n, m];
        for (int i = 0; i < tablero.GetLength(0); i++)
        {
            for (int j = 0; j < tablero.GetLength(0); j++)
            {
                int indice = random.Next(0, valores.Length);
                tablero[i, j] = valores[indice];
                salida[i, j] = "-";
            }
        }

        Console.WriteLine("Entrada: ");
        for (int i = 0; i < tablero.GetLength(0); i++)
        {
            for (int j = 0; j < tablero.GetLength(0); j++)
            {
                Console.Write("|" + tablero[i, j]);
            }
            Console.Write("|\n");
        }


        Console.WriteLine("\nSalida: ");
        for (int i = 0; i < tablero.GetLength(0); i++)
        {
            for (int j = 0; j < tablero.GetLength(0); j++)
            {
                Console.Write("|" + salida[i, j]);
            }
            Console.Write("|\n");
        }
        Console.Write("\n");
    }
}
