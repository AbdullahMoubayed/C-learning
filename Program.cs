int månad = DateTime.Now.Month;

static String printMonday(int month){
    int år = DateTime.Now.Year;
    int dag = DateTime.Now.Day;
    var dayAtWeek = DateTime.Now.DayOfWeek;
    var datum = "";

    DateTime date = new DateTime(år, month,);

    for (int i = 1; i <= date.Day; i++)
    {
        if (date.ToString("d") == "monday"){
            DateTime date2 = new DateTime(2021, month, i);
            datum = date.ToString("MMMM") + "-" + date.Day;
        }        
    }

    return datum;

}

for (var i = 2; i <= månad + 1; i++)
{
    Console.WriteLine(printMonday(i));
}