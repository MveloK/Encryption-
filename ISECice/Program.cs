using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a message to encrypt or decrypt:");
        string message = Console.ReadLine();

        string encryptedMessage = EncryptDecrypt(message);

        Console.WriteLine($"Encrypted/Decrypted message: {encryptedMessage}");
    }

    static string EncryptDecrypt(string input)
    {
        char[] chars = input.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            if (char.IsLetter(chars[i]))
            {
                char baseChar = char.IsUpper(chars[i]) ? 'A' : 'a';
                chars[i] = (char)(((chars[i] + 13 - baseChar) % 26) + baseChar);
            }
        }

        return new string(chars);
    }
}
