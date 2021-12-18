// Spara alla poäng i en variabel
int point = 0;

// Alla inmatningar som kan tolkas till sant eller falskt
String [] santa = { "sant", "S", "ja", "true", "T"};
String [] falskta = { "falskt", "f", "nej", "false", "f"};

// Funktionen som undersöker ifall svaret är rätt eller falskt genom att gemföra inmatningen efter tokningen med facit
int checkAnswer(Boolean answer, String matning){

  // Skapar en variabel som sparar användarens svar efter tolkningen
  Boolean inmatning = true;

  // Loopar igenom santa array och ser om använderen har matat in en av orden som finns i arrayn
  foreach (String item in santa)
  {
    // Variabeln match som sparar antalet matchningar som inmatningen matchar med arrayn, så om det matchar med en eller mer så betyder det att han har matat in sant
    int match = 0;

    // För varje gång man loppar igeon arrayn undersöker man om 'item' dvs. current item matchar 'matning' som är facit
    if (matning == item)
    {
      // Om det gör det så ska man addera en till match array
      match++;
    }

    // I slutet ser man om variabeln match är större än noll allså om det finns några matchningar så sätter man inmatningen till sant
    if (match > 0)
    {
      inmatning = true;
    }
  }

  // Här gör man exact lika dant som i förra foreach men man undersöker om inmatningen kan tolkas till falskt istället
  foreach (String item in falskta)
  {
    int match = 0;

    if (matning == item)
    {
      match++;
    }

    if (match > 0)
    {
      inmatning = false;
    }
  }

  if (inmatning == answer)
  {
    return point++;
  }

  return 0;
}

Console.WriteLine("Det kan finnas mer än två masters i ett Bluetooth nätverk.");
String answer_a = Console.ReadLine();
checkAnswer(false, answer_a);

Console.WriteLine("Harald Blåtand uppfann Bluetooth tekniken.");
var answer_b = Console.ReadLine();
checkAnswer(false, answer_b);

Console.WriteLine("Bluetooth nät av apparater kallas för mininät.");
var answer_c = Console.ReadLine();
checkAnswer(false, answer_c);

Console.WriteLine("Bluetooth använder radiovågor.");
var answer_d = Console.ReadLine();
checkAnswer(true, answer_d);

Console.WriteLine("Det kan finnas mer än två slavar i ett Bluetooth nätverk.");
var answer_e = Console.ReadLine();
checkAnswer(true, answer_e);

Console.WriteLine("Bluetooth använder 2,4, 2,45 och 2,48 frekvenser.");
var answer_f = Console.ReadLine();
checkAnswer(true, answer_f);

Console.WriteLine("1981 lanserades de första hemdatorerna. Bland tillverkarna  fanns sådana välkända företag som Apple.");
var answer_g = Console.ReadLine();
checkAnswer(true, answer_g);

Console.WriteLine("SSd-disk är  Solid State disk innebär, en hårddisk uppbyggd av flash.minne. Helt utan rörliga delar.");
var answer_h = Console.ReadLine();
checkAnswer(true, answer_h);

Console.WriteLine("DDR HyperX är en typ av DIMM minnen.");
var answer_i = Console.ReadLine();
checkAnswer(true, answer_i);

Console.WriteLine("Standard bussen som finns på moderkortet är PCIe och PCI-Express.");
var answer_j = Console.ReadLine();
checkAnswer(true, answer_j);

Console.WriteLine("Moderkortet  kallas ofta för CPU (Central Processing Unit).");
var answer_k = Console.ReadLine();
checkAnswer(false, answer_k);

Console.WriteLine("Indataenhet = tangentbord, pekdon (mus), scanner.");
var answer_l = Console.ReadLine();
checkAnswer(true, answer_l);

Console.WriteLine("I lådan monteras alla komponenter som tillhör själva datorn t.ex. tangentbord, pekdon (mus), scanner.");
var answer_m = Console.ReadLine();
checkAnswer(false, answer_m);

Console.WriteLine("ENERGY STAR är ett internationellt frivilligt märkningsprogram för energieffektivitet");
var answer_n = Console.ReadLine();
checkAnswer(true, answer_n);

Console.WriteLine("RoHS betyder Restriction of Hazardous Substances");
var answer_o = Console.ReadLine();
checkAnswer(true, answer_o);

Console.WriteLine("Tandy var första elektroniska datorn tillverkades redan 1946.");
var answer_p = Console.ReadLine();
checkAnswer(false, answer_p);

String calc(int points){
  switch (points){
    case <= 9: 
      return "F";
    case <= 12:
      return "E";
    case <= 14:
      return"C";
    case 15:
      return "B";
    case 16:
      return "A";
    case > 18:
      return "A++";
    default:
      return "$hit";
  }
}

Console.WriteLine("Ditt betyg är: " + calc(point) + " och fina poäng är: " + point);