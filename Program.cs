﻿string nome1, nome2, apoio;

Console.WriteLine("Troca de Nomes");
Console.WriteLine();

Console.Write("Nome 1: ");
nome1 = Console.ReadLine()!;
Console.Write("Nome 2: ");
nome2 = Console.ReadLine()!;

apoio = nome1;
nome1 = nome2;
nome2 = apoio;

Console.WriteLine("\nTrocando os nomes, temos:\n");

Console.WriteLine($"Nome 1 = {nome1}");
Console.WriteLine($"Nome 2 = {nome2}");