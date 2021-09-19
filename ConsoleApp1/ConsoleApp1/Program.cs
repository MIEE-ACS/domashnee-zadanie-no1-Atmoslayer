//Задание 1, Вариант 18// 

using System;

class Program
{
    public static void Main(string[] args)

    {

        Console.WriteLine("Введите значение собственной скорости лодки км/ч:"); //Выводим информацию о необходимых данных
        string str1 = Console.ReadLine(); //Считываем и запоминаем данные
        double V = Convert.ToDouble(str1); //Полученные данные конвертируем в нужный тип, т.к. работаем с числами 
        
        if (V < 0)  //Проверяем данные на допустимость
        {
                Console.WriteLine("Собственная скорость лодки отрицательной быть не может");
                Environment.Exit(0);
        }


        Console.WriteLine("Введите значение скорости течения реки в км/ч:");
        string str2 = Console.ReadLine();
        double U = Convert.ToDouble(str2);

        if (U < 0)
        {
            Console.WriteLine("Скорость течения реки отрицательной быть не может");
            Environment.Exit(0);
        }

        else if (U >= V) //Проверяем данные на допустимость
        {
            Console.WriteLine("Скорость течения реки превышает или равно скорости лодки");
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Введите значение времени движения лодки по озеру в ч:");
            string str3 = Console.ReadLine();
            double T1 = Convert.ToDouble(str3);

            if (T1 < 0)
            {
                Console.WriteLine("Время отрицательным быть не может");
                Environment.Exit(0);
            }

            Console.WriteLine("Введите значение времени движения лодки против течения реки в ч:");
            string str4 = Console.ReadLine();
            double T2 = Convert.ToDouble(str4);

            if (T1 < 0)
            {
                Console.WriteLine("Время отрицательным быть не может");
                Environment.Exit(0);
            }


            double S = (T1 * V) + (T2 * (V - U)); //Считаем пройденный путь 
            Console.WriteLine("Путь, пройденный лодкой: " + S); //Выводим полученное значение 
        }
    }
}