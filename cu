int soma = 0;
        int numero;

        do
        {
            Console.WriteLine("Digite um número (ou 0 para sair):");
            numero = int.Parse(Console.ReadLine());
            soma += numero;
        } while (numero != 0);

        Console.WriteLine("A soma de todos os números digitados é: " + soma);
