using System;

class Program
{
    static void Main()
    {
        while (true) {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Encode");
        Console.WriteLine("2. Decode");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice (1 , 2 or 3): ");

        string? choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.Write("Enter text to encode: ");
            string? input = Console.ReadLine();
            string? encoded = Encode(input);
            Console.WriteLine($"Encoded: {encoded}");
        }
        else if (choice == "2")
        {
            Console.Write("Enter text to decode: ");
            string? input = Console.ReadLine();
            string? decoded = Decode(input);
            Console.WriteLine($"Decoded: {decoded}");
        }
            else if (choice == "3")
            {
                Console.WriteLine("Exiting program...");
                break; 
            }
            else
        {
            Console.WriteLine("Invalid choice. Please enter 1 or 2.");
        }
    }
    }

    static string Encode(string text)
    {
        return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(text));
    }

    static string Decode(string base64Text)
    {
        try
        {
            return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(base64Text));
        }
        catch (FormatException)
        {
            return "Invalid Base64 string!";
        }
    }
}

