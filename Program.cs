using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = @"
           3 я впевнений що в цьому коді є числа 12 
        ";
        Console.WriteLine("введений текст " + text);
        string pattern = "\\d"; // Регулярний вираз для пошуку цифр

        bool containsDigits = Regex.IsMatch(text, pattern);

        if (containsDigits)
        {
            Console.WriteLine("Текст містить цифри.");
        }
        else
        {
            Console.WriteLine("Текст не містить цифр.");
        }
    }
    
}
