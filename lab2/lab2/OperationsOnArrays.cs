using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{

    public class OperationsOnArrays
    {
        public double[] Array;

        public OperationsOnArrays(double[] array)
        {
            Array = array;
        }

        public OperationsOnArrays()
        {
            Random random = new Random();
            double[] array = new double[random.Next(1, 10)];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
            }
            Array = array;
        }

        public void ShowArray()
        {
            foreach (var i in Array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        public static OperationsOnArrays operator +(OperationsOnArrays array1, OperationsOnArrays array2)
        {
            OperationsOnArrays tmp = new OperationsOnArrays();
            int kol = 0;
            tmp.Array = new double[array1.Array.Length + array2.Array.Length];
            for (int i = 0; i < array2.Array.Length; i++, kol++)
            {
                tmp.Array[kol] = array2.Array[i];
            }
            for (int i = 0; i < array1.Array.Length; i++, kol++)
            {
                tmp.Array[kol] = array1.Array[i];
            }
            return tmp;
        }

        public static OperationsOnArrays operator *(OperationsOnArrays array, double num)
        {
            for (int i = 0; i < array.Array.Length; i++)
            {
                array.Array[i] *= num;
            }
            return array;
        }

        public static OperationsOnArrays operator /(OperationsOnArrays array, double num)
        {
            if (num != 0)
            {
                for (int i = 0; i < array.Array.Length; i++)
                {
                    array.Array[i] /= num;
                }
            }
            return array;
        }

        public static bool operator ==(OperationsOnArrays array1, OperationsOnArrays array2)
        {
            for (int i = 0; i < array1.Array.Length; i++)
            {
                if (array1.Array[i] != array2.Array[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static bool operator !=(OperationsOnArrays array1, OperationsOnArrays array2)
        {
            for (int i = 0; i < array1.Array.Length; i++)
            {
                if (array1.Array[i] != array2.Array[i])
                {
                    return true;
                }
            }
             return false;
        }
    }
}
