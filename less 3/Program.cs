using System;
using System.Globalization;

namespace less_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Напишите программу, в которую пользователь вводит два числа и
            //выводит результат их умножения. При этом программа должны запрашивать у
            //пользователя ввод чисел, пока оба вводимых числа не окажутся в диапазоне от 0 до 10.
            //Если введенные числа окажутся больше 10 или меньше 0, то программа должна вывести
            //пользователю о том, что введенные числа недопустимы, и повторно
            //запросить у пользователя ввод двух чисел. Если введенные числа принадлежат
            //диапазону от 0 до 10, то программа выводит результат умножения.(готово)

            //TODO: Задание 2
            //Написать класс, который будет хранить время с точностью до секунды

            /*int[] arr = new int[2];

            while (true)
            {
                int count = 0;
                Console.WriteLine("enter 2 numbers [0 to 10] ->  ");
                string[] splitted = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i<splitted.Length; i++)
                {
                    Int32.TryParse(splitted[i], out arr[count]); //почему count ???
                    if (arr[count] >= 0 && arr[count] <= 10)
                    {
                        count++;
                    }
                    
                }
               if (count >= 2)
                {
                    break;
                }
               
            }
            Console.WriteLine($"{arr[0]} * {arr[1]} = {arr[0] * arr[1]} ");
        }*/
        }
    }
}
