using System;

class Quest09
{
	static void Main(string[] args)
	{
		int soma = 0;
		int numero;

		do
		{
			Console.WriteLine("Digite um n�mero (ou 0 para sair):");
			numero = int.Parse(Console.ReadLine());
			soma += numero;
		} while (numero != 0);

		Console.WriteLine("A soma de todos os n�meros digitados �: " + soma);
	}
}