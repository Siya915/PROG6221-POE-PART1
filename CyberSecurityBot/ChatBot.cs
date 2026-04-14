using System;
using System.Threading;

public class ChatBot
{
    public string UserName { get; set; }

    public void StartChat()
    {
        AskName();
        ShowWelcome();

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nYou: ");
            Console.ResetColor();

            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("⚠ Please enter something.");
                continue;
            }

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("👋 Goodbye! Stay safe online.");
                break;
            }

            Respond(input.ToLower());
        }
    }

    private void AskName()
    {
        Console.Write("Enter your name: ");
        UserName = Console.ReadLine();
    }

    private void ShowWelcome()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Utils.TypeEffect($"Hello {UserName}! Welcome to the Cybersecurity Awareness Bot.");
        Console.ResetColor();

        DisplayHelpMenu();
    }

    private void DisplayHelpMenu()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;

        Console.WriteLine("\n==========================================");
        Console.WriteLine("💡 What you can ask me:");
        Console.WriteLine("==========================================");
        Console.WriteLine("• How are you?");
        Console.WriteLine("• What is your purpose?");
        Console.WriteLine("• What can I ask you about?");
        Console.WriteLine("• Tell me about password safety");
        Console.WriteLine("• What is phishing?");
        Console.WriteLine("• Tips for safe browsing");
        Console.WriteLine("==========================================");
        Console.WriteLine("👉 Type 'exit' if you want to close the chatbot.");
        Console.WriteLine("==========================================\n");

        Console.ResetColor();
    }

    private void Respond(string input)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        if (input.Contains("how are you"))
        {
            Console.WriteLine("I'm functioning perfectly and ready to help!");
        }
        else if (input.Contains("purpose"))
        {
            Console.WriteLine("I help users stay safe online by teaching cybersecurity basics.");
        }
        else if (input.Contains("what can i ask"))
        {
            Console.WriteLine("Ask about passwords, phishing, or safe browsing.");
        }
        else if (input.Contains("password"))
        {
            Console.WriteLine("Use strong passwords with uppercase, lowercase, numbers, and symbols.");
        }
        else if (input.Contains("phishing"))
        {
            Console.WriteLine("Phishing is when attackers trick you into giving personal info. Avoid suspicious emails.");
        }
        else if (input.Contains("browsing"))
        {
            Console.WriteLine("Always check for HTTPS and avoid unsafe websites.");
        }
        else
        {
            Console.WriteLine("I didn't quite understand that. Could you rephrase?");
        }

        Console.ResetColor();
    }
}
