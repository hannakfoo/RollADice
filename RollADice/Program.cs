// https://en.wikipedia.org/wiki/Dice_notation

using System.Runtime.CompilerServices;
using RollADice;

Console.WriteLine(@"((_______\");
Console.WriteLine(@"     _______ /       \O O\\");
Console.WriteLine(@"    /O     /\   /  \      \\");
Console.WriteLine(@"   /   O  /O \ / O  \O____O\ ))\");
Console.WriteLine(@"((/ _____O /    \\    / O /\");
Console.WriteLine(@"  \O O\    / \  /   O  /\");
Console.WriteLine(@"   \O    O\ O/   \/_____O/\");
Console.WriteLine(@"    \O____O\/ )) mrf      ))\");
Console.WriteLine(@"  ((\");
Console.WriteLine("==================================");
Console.WriteLine("         Roll Tha Dice!!         ");
Console.WriteLine("==================================");


Console.ReadLine();


RollThaDice("10D6");
RollThaDice("100D6");
RollThaDice("5D6");
RollThaDice("1D30");


Console.ReadKey();

int RollThaDice(string diceNotationInput)
{
    int result = 0;
    var diceNotation = new DiceNotation(diceNotationInput);

    Console.WriteLine($"Rolling the dice {diceNotation.Times} times with {diceNotation.Faces} sides");

    for (int i = 0; i < diceNotation.Times; i++)
    {
        result = new Random().Next(1, diceNotation.Faces);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Dice rolled: {result}");
    }

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Final result: {result}");
    return result;
}