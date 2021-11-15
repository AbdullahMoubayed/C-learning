var random = new Random().Next(1, 101);
Console.WriteLine(random);
Console.WriteLine("Gissa talet!");
var talet = 0;

for (int i = talet; i != random;)
{
    talet = Int32.Parse(Console.ReadLine());
    if (talet != random)
    {
        Console.WriteLine("Fel, gissa igen!");
        continue;
    }
    else
    {
        Console.WriteLine("Rätt!");
        break;
    }
}