﻿string nome1, nome2, apoio;

Console.WriteLine("Troca de Nomes");
Console.WriteLine();

Console.Write("Digite um nome: ");
nome1 = Console.ReadLine()!;
Console.Write("Digite outro nome: ");
nome2 = Console.ReadLine()!;

apoio = nome1;
nome1 = nome2;
nome2 = apoio;

Console.WriteLine("\nTrocando os nomes, temos:\n");

Console.WriteLine($"NOME 1 = {nome1}");
Console.WriteLine($"NOME 2 = {nome2}");