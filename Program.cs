Console.WriteLine("Ange bredd: ");
int bredd = 10;
 
Console.WriteLine("Ange höjd: ");
int höjd = 10;
 
var hash = "#";
var zero = "0";
 
for (int i = 0; i < höjd; i++){
    for (int j = 0; j < bredd; j++){
        Console.WriteLine(hash + zero);
    }
    Console.WriteLine(hash + zero);
}