Console.WriteLine("Ange bredd: ");
int bredd = Int32.Parse(Console.ReadLine());
 
Console.WriteLine("Ange höjd: ");
int höjd = Int32.Parse(Console.ReadLine());

var hash = "#";
var zero = "0";
 
for (int i = 0; i < höjd; i++){
    for (int j = 0; j < bredd; j++){
        Console.Write(zero + hash);
    }
 
    Console.WriteLine();
}
