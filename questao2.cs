using System;

int sets1, sets2;
string team1,  team2;

do
{
    Console.WriteLine("Escreva o nome do primeiro time: ");
    team1 = Console.ReadLine();

    Console.WriteLine("Escreva o nome do segundo time: ");
    team2 = Console.ReadLine();

    Console.WriteLine($"Escreva quantos sets o {team1} ganhou: ");
    sets1 = int.Parse(Console.ReadLine());

    Console.WriteLine($"Escreva quantos sets o {team2} ganhou: ");
    sets2 = int.Parse(Console.ReadLine());

    Console.Clear();
}while ((sets1 > 3) || (sets2 > 3) || (sets1 < 0) || (sets2 < 0) || (sets1 == sets2));

if (sets1 == 3)
{
    Console.WriteLine($"{team1} foi o vencedor.");
}
else 
    Console.WriteLine($"{team2} foi o vencedor.");

Console.ReadKey();  