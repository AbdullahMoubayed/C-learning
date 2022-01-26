private static string API_key = "JiAE6CmazCKQZD9ZyZPZ2EHIb";
private static string API_key_secret = "sW9u1Imrp5q4XXAFwbG9XXpaFA04bGxAo2fYpNs7Hp39bxFW4K";
// var bearer_token = "AAAAAAAAAAAAAAAAAAAAADsgYQEAAAAAJmiWIugfa4jmzsGENvpJZ5aZH7U%3DZz4WupffZvAZM1FrmqJdtzLURtkwAqZzksLIyf9SDnlP6hILRA";
private static string access_token = "1287453934773305357-RuGRJdwcX8hKBKohE7O0tGDqc1oxNw";
private static string access_token_secret = "eR0q2jbJf2Z9GpnaLaYvOq37g4POYLbQODGR1Yo04kNcN";


private static TwitterService service = new TwitterService(API_key, API_key_secret, access_token, access_token_secret);

static void Main(string[] args){

  Console.WriteLine($"<{DateTime.Now}> - Bot started");
  SendTweet("Hello from C# 🤗");
  Console.Read();

}

private static void SendTweet(string _status) {

  service.SendTweet(new SendTwitOptions { Status = _status}, (tweet, response) => {

    if (response.StatusCode == HttpStatusCode.OK) {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("$<{DateTime.Now}> Tweet sent successfully");
      Console.ResetColor();

    } else {

      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine($"<ERROR> " + response.ErrorMessage);
      Console.ResetColor();

    }
  });
}