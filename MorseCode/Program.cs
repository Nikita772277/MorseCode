using Codewars;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

MorseCode morseCode = new();
void Menu()
{
    Console.WriteLine();
    Console.WriteLine($"1) Кодировка текста в азбуку морзе");
    Console.WriteLine($"2) Декодировка азбуки морзе в текст");
    Console.WriteLine();
}
void UseMenu()
{
    while (true)
    {
        Menu();
        string enter = Console.ReadLine();
        bool check = int.TryParse(enter, out int result);
        if (result == 1)
        {
            Console.WriteLine($"Введите текст");
            string text = Console.ReadLine();
            morseCode.ToMorse(text);
        }
        else if (result == 2)
        {
            Console.WriteLine($"Введите текст состоящий из . и -");
            string text = Console.ReadLine();
            morseCode.Decode(text);
        }
        else
        {
            Console.WriteLine($"Выберите пункт из меню");
        }
    }
}
UseMenu();