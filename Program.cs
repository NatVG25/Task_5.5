using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0; //инициализация переменной N
            Console.Write("Введите целое число: "); //вывод команды на консоль
            N = Convert.ToInt32(Console.ReadLine()); //ввод с клавиатуры значения N
            int[,] array = new int[N, N]; //объявление массива
            int x = 0;

            for (int i = 0; i < N; i++)  //цикл для строк
            {
                for (int j = 0; j < N; j++) //цикл для столбцов
                {
                    if ((x % 2) != 0) //условие: с какого значения начинается строка, если остаток x/2 не равен 0, то
                    {
                        array[i, j] = 1 - (i + j) % 2;
                        Console.Write("{0} ", array[i, j]);//вывод элементов массива
                    }

                    else // в противном случае:
                    {
                        array[i, j] = 1 - (i + j) % 2;
                        Console.Write("{0} ", array[i, j]);//вывод элементов массива
                    }

                }
                Console.WriteLine();//перевод на новую строку
            }
            Console.ReadKey();
        }
    }
}
