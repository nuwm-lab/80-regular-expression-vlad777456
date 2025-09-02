using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    // Функція для пошуку кольорів у HEX-форматі
    static List<string> ExtractHexColors(string inputText)
    {
        // Регулярний вираз: # + 6 символів (літери A-F або цифри)
        string pattern = @"#([A-Fa-f0-9]{6})";

        MatchCollection matches = Regex.Matches(inputText, pattern);
        List<string> colors = new List<string>();

        foreach (Match match in matches)
        {
            colors.Add(match.Value);
        }

        return colors;
    }

    static void Main()
    {
        string inputText = @"
            Тут є кілька кольорів: #FF5733, #00ff00 і випадковий текст 123 #ABC123 #xyzxyz
        ";

        Console.WriteLine("Введений текст: " + inputText);

        // Виклик функції для пошуку кольорів
        List<string> foundColors = ExtractHexColors(inputText);

        if (foundColors.Count > 0)
        {
            Console.WriteLine("Знайдені HEX-кольори:");
            foreach (string color in foundColors)
            {
                Console.WriteLine(color);
            }
        }
        else
        {
            Console.WriteLine("У тексті немає HEX-кольорів.");
        }
    }
}
