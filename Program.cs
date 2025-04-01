using System;
using System.Threading;

namespace CybersecurityChatbot
{
    class CyberAwarenessBot
    {
        static void Main(string[] args)
        {
            // Display the CyberX ASCII logo
            DisplayAsciiLogo();

            // Greet the user and ask for their name
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nHello, welcome to CyberX – How can I help you?");
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            // Personalize the greeting
            Console.WriteLine($"\nHello, {userName}! I'm here to help you stay safe online. Let's get started!");
            Console.ResetColor();

            // Main conversation loop
            bool continueChat = true;
            while (continueChat)
            {
                // Ask the user for input
                Console.WriteLine("\nWhat would you like to learn about today?");
                Console.WriteLine("1. Password Safety");
                Console.WriteLine("2. Phishing Attacks");
                Console.WriteLine("3. Safe Browsing Tips");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option (1-4): ");
                string userChoice = Console.ReadLine();

                // Respond based on user choice
                switch (userChoice)
                {
                    case "1":
                        DisplayPasswordSafetyTips();
                        break;
                    case "2":
                        DisplayPhishingTips();
                        break;
                    case "3":
                        DisplaySafeBrowsingTips();
                        break;
                    case "4":
                        continueChat = false;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\nThank you for chatting with CyberX! Stay safe online.");
                        Console.ResetColor();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Oops! I didn't quite understand that. Please choose a number between 1 and 4.");
                        Console.ResetColor();
                        break;
                }
            }
        }

        // Display the CyberX ASCII logo
        static void DisplayAsciiLogo() // ✅ Ensure this is STATIC
        {
            string asciiLogo = @"
   CCCCC    Y   Y   BBBBB     EEEEE    RRRRR    X     X  
  C          Y Y    B    B    E        R   R     X   X 
  C           Y     BBBBB     EEEE     RRRRR       X         
  C           Y     B    B    E        R   R      X X    
   CCCCC      Y     BBBBB     EEEEE    R    R   X     X 
";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(asciiLogo);
            Console.ResetColor();
            Thread.Sleep(1500); // Add a slight delay to enhance the experience
        }

        // Display password safety tips
        static void DisplayPasswordSafetyTips()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPassword Safety Tips:");
            Console.WriteLine("- Use at least 12 characters (longer passwords are better).");
            Console.WriteLine("- Include numbers, symbols, and both uppercase and lowercase letters.");
            Console.WriteLine("- Don't reuse passwords across multiple sites.");
            Console.WriteLine("- Use a password manager to store your passwords safely.");
            Console.ResetColor();
        }

        // Display phishing attack tips
        static void DisplayPhishingTips()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPhishing Attack Tips:");
            Console.WriteLine("- Be cautious of unsolicited emails and messages asking for personal information.");
            Console.WriteLine("- Verify the sender's email address carefully.");
            Console.WriteLine("- Avoid clicking on links in suspicious emails, especially if they seem urgent.");
            Console.WriteLine("- Look for spelling mistakes and grammatical errors in suspicious messages.");
            Console.ResetColor();
        }

        // Display safe browsing tips
        static void DisplaySafeBrowsingTips()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nSafe Browsing Tips:");
            Console.WriteLine("- Use HTTPS websites for secure browsing (look for the padlock symbol).");
            Console.WriteLine("- Avoid downloading files or clicking on pop-up ads from unknown sources.");
            Console.WriteLine("- Keep your browser and antivirus software up-to-date.");
            Console.WriteLine("- Always log out of your accounts when you’re done, especially on public computers.");
            Console.ResetColor();
        }
    }
}
