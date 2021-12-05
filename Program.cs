DateTime date = new DateTime(DateTime.Now.Year, 1, 1);

for (int i = 0; i <= 365; i++)
{
  DateTime newDate = date.AddDays(i);

  if (newDate.DayOfWeek == DayOfWeek.Monday)
  {
    Console.WriteLine(newDate.ToString() + " är måndag");
  }  
}