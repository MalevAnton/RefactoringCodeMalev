using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace RefactoringCodeMalev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Математические операции"); //название

            Console.Write("Введите число a: "); // ввод первого числа в консольное приложение

            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число b: "); // ввод второго числа в консольное приложение

            int number2 = Convert.ToInt32(Console.ReadLine());

            getAddition(number1, number2); // сложение

            getSubtraction(number1, number2); // вычитание

            getMultiplication(number1, number2); // умножение

            getDivision(number1, number2); // деление

            Console.Write("\nВведите число для цвета: "); // ввод другого числа для цвета в консольное приложение

            int numberColor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nЦвет: {GetColor(numberColor)}"); // цвет результата
        }

        static void getAddition (int a, int b) // метод для сложения
        {
            int c = a + b;

            Console.WriteLine($"\nСумма = {c}\n"); // вывод результата
        }

        static void getSubtraction (int a, int b) // метод для вычитания
        {
            int c = a - b;

            Console.WriteLine($"Разность = {c}\n"); // вывод результата
        }

        static void getMultiplication (int a, int b) // метод для умножения
        {
            int c = a * b;

            Console.WriteLine($"Произведение = {c}\n"); // вывод результата
        }

        static void getDivision (int a, int b) // метод для деления
        {
            double c = a / b;
             
            Console.WriteLine($"Частное = {c}"); // вывод результата
        }

        private static string GetColor(int forNumberColor) // метод для цвета
        {
            switch (forNumberColor) 
            {
                case 1: // если выбор 1, показывает красный цвет

                    return "Красный"; // вывод результата

                break;

                case 2: // если выбор 2, показывает желтый цвет

                    return "Желтый"; // вывод результата

                break;

                case 3: // если выбор 3, показывает зеленый цвет

                    return "Зеленый"; // вывод результата

                break;

                default: // если выбор 4 и больше, показывает, что нет цвета

                    return "Нет цвета"; // вывод результата

                break;

            }
        }
    }
}