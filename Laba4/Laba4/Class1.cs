using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
//Створіть клас. У тілі класу створіть метод, що приймає значення.
//Метод, у реалізації повинен виводити в дебаг значення всіх використовуваних у ньому аргументів.
//Реалізуйте можливість того, щоб у разі успадкування від даного класу інших класів,
//та виклику відповідного методу їх екземпляра, рядки (для опису завдання, це можуть бути і не рядки,
//а відповідні програмі типи), передані як аргументи методів,
//виводилися в консоль із зазначенням їх типів різними кольорами. Обов'язково використовуйте типи.
{
    internal class Class1
    {
        public static void Mathod1(double a, string b, int c)
        {
            Type t = a.GetType();

            if (t.Equals(typeof(int)))
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            else if (t.Equals(typeof(double)))
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }

            Console.WriteLine(a.GetType().ToString() + " " + a);


            t = b.GetType();

            if (t.Equals(typeof(int)))
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            else if (t.Equals(typeof(double)))
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }

            Console.WriteLine(b.GetType().ToString() + " " + b);


            t = c.GetType();

            if (t.Equals(typeof(int)))
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            else if (t.Equals(typeof(double)))
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }

            Console.WriteLine(c.GetType().ToString() + " " + c);


            Console.ResetColor();
        }
    }
}
