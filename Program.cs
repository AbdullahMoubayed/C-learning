Console.WriteLine("inter some number: ");
int num = Convert.ToInt32(Console.ReadLine());
int col, row;

for (row = 1; row <= num; row++)
{
    for (col = num; col >= row; col--)
    {
        Console.Write(" # ");
    }
    
    Console.WriteLine();
}