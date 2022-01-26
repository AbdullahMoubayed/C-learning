var API_key = "JiAE6CmazCKQZD9ZyZPZ2EHIb";
var API_key_secret = "sW9u1Imrp5q4XXAFwbG9XXpaFA04bGxAo2fYpNs7Hp39bxFW4K";
var bearer_token = "AAAAAAAAAAAAAAAAAAAAADsgYQEAAAAAJmiWIugfa4jmzsGENvpJZ5aZH7U%3DZz4WupffZvAZM1FrmqJdtzLURtkwAqZzksLIyf9SDnlP6hILRA";
var access_token = "1287453934773305357-RuGRJdwcX8hKBKohE7O0tGDqc1oxNw";
var access_token_secret = "eR0q2jbJf2Z9GpnaLaYvOq37g4POYLbQODGR1Yo04kNcN";

var tweetText = "Hello from C# 🤗";

var userClient = new TwitterClient(API_key, API_key_secret, access_token, access_token_secret);

Console.WriteLine($"<{DateTime.Now}> - Bot started");
SendTweet(tweetText);
Console.Read();

static void SendTweet(string _status) {
}