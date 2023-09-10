// GicellyGomes
﻿Console.WriteLine("--- Pet Hotel Check-in ---\n");

Console.Write("Especie......: ");
string especie = Console.ReadLine()!;

Console.Write("Raça.........: ");
string raca = Console.ReadLine()!;

Console.Write("Nome do Pet......: ");
string apelido = Console.ReadLine()!;

Console.Write("Idade do Pet.: ");
string idade = Console.ReadLine()!;

Console.Write("Pelagem/ ou cor..: ");
string pelagemCor = Console.ReadLine()!;

Console.WriteLine();
Console.WriteLine("*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*");
Console.Write("|                 ");
Console.Write("Pet Hotel \"Happy Animals\"");
Console.WriteLine("                  |");

Console.WriteLine("*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*");
Console.Write("| Espécie: ");
Console.Write(especie.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15));
Console.Write(" | Raça: ");

Console.Write(raca.Trim().ToUpper().PadLeft(22, '.').Substring(0, 22));

Console.WriteLine(" |");


Console.WriteLine("*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*");
Console.Write("| Atende pelo apelido de: ");


Console.Write(apelido.Trim().ToUpper().PadLeft(31, '.').Substring(0, 31));
Console.WriteLine(" |");
Console.Write("| Idade: ");


Console.Write($"{idade.Trim().ToUpper().PadLeft(2, '0').Substring(0, 2)} ano(s)");
Console.Write(" | Pelagem/cor: ");


Console.Write(pelagemCor.Trim().ToUpper().PadLeft(23, '.').Substring(0, 23));
Console.WriteLine(" |");


Console.Write("*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*");


