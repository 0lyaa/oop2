using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4._1
//Створити клас "А", що є класом, який у вигляді параметра повинен приймати екземпляр іншого класу,
//відповідно до Вашої програми. Створіть базовий клас "Б". У тілі класу створіть методи.
//Створіть 3 похідних класи від базового класу та перевизначте кожен із методів, залежно від необхідності.
//Конструктор класу А приймає аргументи типу базового класу "Б".
//Передбачте можливість, що користувач може передати 2 або 3 аргументи.
//Виведіть у консоль дерево (структуровано) властивостей всіх похідних класів.
{
    internal class A
    {
        public A(B b1, B b2)
        {
            Console.WriteLine(b1.name + " (" + b1.PrintInfo() + "):");
            b1 = new B1();
            b1.name = "B1";
            b1.SetColor();
            Console.WriteLine("\t" + b1.name + " (" + b1.PrintInfo() + ")");
            b1 = new B2();
            b1.name = "B2";
            b1.SetColor();
            Console.WriteLine("\t" + b1.name + " (" + b1.PrintInfo() + ")");
            Console.ResetColor();
            Console.WriteLine(b2.name + " (" + b2.PrintInfo() + "):");
            b2 = new B3();
            b2.name = "B3";
            b2.SetColor();
            Console.WriteLine("\t" + b2.name + " (" + b2.PrintInfo() + ")");
            Console.ResetColor();
        }

        public A(B b1, B b2, B b3)
        {

        }
    }
}
