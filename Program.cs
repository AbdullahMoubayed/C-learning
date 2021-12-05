int before = 0;
int after = 1;

for (; after < 100000000;)
{
  int answer = (after + before);
  
  Console.WriteLine(answer);

  before = after;
  after = answer;
}