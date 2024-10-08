using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._10_syntax2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Задание 1
            Пользователь вводит с клавиатуры число в диапа -
            зоне от 1 до 100.Если число кратно 3(делится на 3 без
            остатка) нужно вывести слово Fizz. Если число кратно 5
            нужно вывести слово Buzz. Если число кратно 3 и 5 нужно
            вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно
            вывести само число.
            Если пользователь ввел значение не в диапазоне от 1
            до 100 требуется вывести сообщение об ошибке.*/
            #region
            int a = 0;
            while(a<1 || a>100) 
            {
                a = int.Parse(Console.ReadLine());
                if (a >= 1 && a <= 100)
                    break;
                else
                    Console.WriteLine("Error.Please write out a number between 1 and 100");
            }

            bool flag = false;

            if(a%3==0)
            {
                flag = true;
                Console.Write("Fizz ");
            }
            if (a % 5 == 0)
            {
                flag = true;
                Console.Write("Buzz");
            }

            if (flag == false)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            #endregion


            //Задание 2
            //Пользователь вводит с клавиатуры два числа. Первое
            //число — это значение, второе число процент, который
            //необходимо посчитать. Например, мы ввели с клавиатуры
            //90 и 10.Требуется вывести на экран 10 процентов от 90.
            //Результат: 9.
            #region
            int digit = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine()) / 100;
            Console.WriteLine(digit*percent + "%");
            #endregion


            //Задание 3
            //Пользователь вводит с клавиатуры четыре цифры.
            //Необходимо создать число, содержащее эти цифры.На -
            //пример, если с клавиатуры введено 1, 5, 7, 8 тогда нужно
            //сформировать число 1578.
            #region
            int first, second, third, fourth;

            while (true)
            {
                Console.Write("Введите первое целое число: ");
                string input = Console.ReadLine();
                Console.Write("Введите второе целое число: ");
                string input2 = Console.ReadLine();
                Console.Write("Введите третье целое число: ");
                string input3 = Console.ReadLine();
                Console.Write("Введите четвертое целое число: ");
                string input4 = Console.ReadLine();

                if (int.TryParse(input, out first) && int.TryParse(input2, out second) &&
                    int.TryParse(input3, out third) && int.TryParse(input4, out fourth))
                    break; 
                else
                    Console.WriteLine("Ошибка: Пожалуйста, введите корректное целое число.");
            }

            string concat = string.Concat(first, second, third, fourth);
            Console.WriteLine($"Конкатенированные значения: {concat}");

            #endregion


            //Задание 4
            //Пользователь вводит шестизначное число.После чего
            //пользователь вводит номера разрядов для обмена цифр.
            //Например, если пользователь ввёл один и шесть — это
            //значит, что надо обменять местами первую и шестую
            //цифры.
            //Число 723895 должно превратиться в 523897.
            //Если пользователь ввел не шестизначное число тре-
            //буется вывести сообщение об ошибке.
            #region
            string sixDig = "";
            Console.WriteLine("Введите шестизначное число:");

            while (true)
            {
                sixDig = Console.ReadLine();
                if (sixDig.Length == 6 && int.TryParse(sixDig, out _))
                    break;
                else
                    Console.WriteLine("Ошибка. Введите шестизначное число");
            }

            int firstSymb, secondSymb;

            while (true)
            {
                Console.WriteLine("Введите номер первого разряда (от 1 до 6):");
                firstSymb = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите номер второго разряда (от 1 до 6):");
                secondSymb = int.Parse(Console.ReadLine());

                if ((firstSymb >= 1 && firstSymb <= 6) && (secondSymb >= 1 && secondSymb <= 6))
                    break;
                else
                    Console.WriteLine("Разряд должен быть от 1 до 6");
            }

            char[] digits = sixDig.ToCharArray();

            int index1 = firstSymb - 1;
            int index2 = secondSymb - 1;

            char tmpSymb = digits[index1];
            digits[index1] = digits[index2];
            digits[index2] = tmpSymb;

            string result = new string(digits);
            Console.WriteLine($"Результат: {result}");
            #endregion


            //Задание 5
            //Пользователь вводит с клавиатуры дату.Приложе -
            //ние должно отобразить название сезона и дня недели.
            //Например, если введено 22.12.2021, приложение должно
            //отобразить Winter Wednesday.
            #region
            Console.WriteLine("Please enter a date (e.g., 2024-10-08):");
            DateTime date = DateTime.Parse(Console.ReadLine());
            string season;
            if (date.Month == 12 || date.Month >= 1 && date.Month <= 2)
                season = "Winter";
            else if (date.Month >= 3 && date.Month <= 5)
                season = "Spring";
            else if (date.Month >= 6 && date.Month <= 8)
                season = "Summer";
            else
                season = "Autumn";
            Console.WriteLine(season + " " + date.DayOfWeek);
            #endregion

            //Задание 6
            //Пользователь вводит с клавиатуры показания тем-
            //пературы.В зависимости от выбора пользователя про -
            //грамма переводит температуру из Фаренгейта в Цельсий
            //или наоборот.
            #region
            Console.WriteLine("В каком формате впишете температуру ? (1 - Цельсий, 2 - Фаренгейт)");
            int tempChoice = int.Parse(Console.ReadLine());

            double temperature = double.Parse(Console.ReadLine());

            switch (tempChoice)
            {
                case 1:
                    Console.WriteLine(Convert.ToString(temperature * 1.8 + 32));
                    break;
                case 2:
                    Console.WriteLine(Convert.ToString((temperature - 32) / 1.8));
                    break;
            }

            #endregion

            //Задание 7
            //Пользователь вводит с клавиатуры два числа. Нужно
            //показать все четные числа в указанном диапазоне. Если
            //границы диапазона указаны неправильно требуется про -
            //извести нормализацию границ. Например, пользователь
            //ввел 20 и 11, требуется нормализация, после которой
            //начало диапазона станет равно 11, а конец 20.
            #region
            int a1 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            if (a1 < b1)
            {
                int temp1 = a1;
                a1 = b1;
                b1 = temp1;
            }

            for(int i = a1; i < b1; i++)
            {
                if(i%2==0)
                    Console.Write(i + " ");
            }
            #endregion
        }




    }
}
