int row, col, num;
Console.WriteLine("Enter number : ");
num = Convert.ToInt32(Console.ReadLine());

for (row = 1; row <= num; row++)
{
    for (col = 1; col <= 1; col++) 
    {

        for (int i = 0; i <= num; i++)
        {
            Console.Write("0");
            Console.Write("#");
        }
        Console.WriteLine();
    }

    for (int i = 0; i <= 5; i++)
    {
        Console.Write("#");
        Console.Write("0");
    }
    
    Console.WriteLine();

}