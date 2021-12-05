int år = DateTime.Now.Year;

for (int i = år; i <= 2050; i++)
{
    var skolttÅr =  DateTime.IsLeapYear(i);

    if (skolttÅr)
    {
        Console.WriteLine(i);
    }
}
