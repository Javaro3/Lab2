using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double[] array1 = new double[3];
            double[] array2 = new double[5];

            for (int i = 0; i < array1.Length; i++)
                array1[i] = random.Next(1, 10);

            for (int i = 0; i < array2.Length; i++)
                array2[i] = random.Next(1, 10);

            OperationsOnArrays object1 = new OperationsOnArrays(array1);
            OperationsOnArrays object2 = new OperationsOnArrays(array2);
            OperationsOnArrays object3 = new OperationsOnArrays();

            Console.WriteLine("//////////Сложение массивов/////////////");
            Console.WriteLine("Первый массив до сложения: ");
            object1.ShowArray();
            Console.WriteLine("Второй массив до сложения: ");
            object2.ShowArray();
            object3 = object1 + object2;
            Console.WriteLine("Первый массив после сложения: ");
            object1.ShowArray();
            Console.WriteLine("Второй массив после сложения: ");
            object2.ShowArray();
            object3.ShowArray();

            Console.WriteLine("//////////Умножение массива на число/////////////");
            Console.WriteLine("Массив до умножения на 4: ");
            object1.ShowArray();
            object1 = object1 * 4;
            Console.WriteLine("Массив после умножения на 4: ");
            object1.ShowArray();

            Console.WriteLine("//////////Деление массива на число/////////////");
            Console.WriteLine("Массив до деления на 4: ");
            object1.ShowArray();
            object1 = object1 / 4;
            Console.WriteLine("Массив после деления на 4: ");
            object1.ShowArray();
        }
    }
}
