using System;

class ejercicio1
{

	static void Main(string[] args)
	{
		double dolares;
		double euros;
		double pesos;
		// dolares=pesos/230;
		// euros=dolares/1.75;
		Console.Write(" Ingrese la cantidad de pesos a convertir : ");
		pesos = Double.Parse(Console.ReadLine());
		Console.Write("la cantidad de dolares son: ");
		Console.WriteLine(pesos / 230);
		Console.Write("La cantidad de euros son : ");
		Console.WriteLine((pesos / 230) / 1.75);
	}

}



