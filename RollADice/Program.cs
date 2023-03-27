// https://en.wikipedia.org/wiki/Dice_notation

using System.Runtime.CompilerServices;

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

while (Console.ReadKey().Key == ConsoleKey.Escape)
{
    RollThaDice("10D6");
}

Console.ReadKey();

int RollThaDice(string diceNotation)
{
    var times = Int32.Parse(diceNotation.Substring(0, 1));
    if (Int32.TryParse(diceNotation.Substring(diceNotation.IndexOf("D") + 1), out var dice))
    {
        for (int i = 0; i < times; i++)
        {
            int randomNumber = new Random().Next(1, dice);
            Console.WriteLine(randomNumber.ToString());
        }
    }

    return 0;
}