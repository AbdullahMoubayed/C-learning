int månad = DateTime.Now.Month;

static string getMonth(int month)
{
    int år = DateTime.Now.Year;
    int dag = DateTime.Now.DayOfYear;
    DateTime date = new DateTime(2021, month, 27);
    return date.ToString("MMMM");
}

for (int i = 1; i <= månad; i++)
{
    Console.WriteLine(getMonth(i));
}