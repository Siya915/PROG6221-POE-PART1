using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Cybersecurity Awareness Bot";

        AudioPlayer.PlayGreeting();
        AsciiArt.DisplayLogo();

        ChatBot bot = new ChatBot();
        bot.StartChat();
    }
}
