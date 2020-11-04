using System;

namespace MaxGiriy_Lesson04_Task01 {

    //Гирий Максим
    //    1. Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые
    //    значения от –10 000 до 10 000 включительно.Заполнить случайными числами.Написать
    //    программу, позволяющую найти и вывести количество пар элементов массива, в которых только
    //    одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих
    //    элемента массива.Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.

    class Program {

        static void Main(string[] args) {
            int[] arr = new int[20];
            FillArray(arr);
            int counter = 0;
            for (int i = 0; i < arr.Length - 1; ++i) {
                if (IsRequiredPair(arr[i], arr[i + 1])) counter++;
            }
            Console.WriteLine($"The number of required pairs is {counter}");
            Console.ReadKey();
        }

        static void FillArray(int[] arr) {
            int maxVal = 10_000, minVal = -10_000;
            Random rand = new Random();
            for (int i = 0; i < arr.Length; ++i) {
                arr[i] = rand.Next(minVal, maxVal);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static bool IsRequiredPair(int a, int b) {
            return a % 3 == 0 && b % 3 != 0 || a % 3 != 0 && b % 3 == 0;
        }
    }
}
