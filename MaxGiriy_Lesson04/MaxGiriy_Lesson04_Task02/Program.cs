using System;
using System.IO;
using System.Net;

namespace MaxGiriy_Lesson04_Task02 {

        //Гирий Максим
        //    2. Реализуйте задачу 1 в виде статического класса StaticClass;
        //    а) Класс должен содержать статический метод, который принимает на вход массив и решает
        //    задачу 1;
        //    б) *Добавьте статический метод для считывания массива из текстового файла.Метод должен
        //    возвращать массив целых чисел;
        //    в)**Добавьте обработку ситуации отсутствия файла на диске

    class Program {

        static void Main(string[] args) {
            int[] arr = StaticClass.CreateArrayFromFile("array.txt");
            if (arr != null) {
                int pairsNumber = StaticClass.RequiredPairCounter(arr);
                Console.WriteLine($"The number of required pairs is {pairsNumber}");
                Console.ReadKey();
            }
        }

        static class StaticClass {
            public static int RequiredPairCounter(int[] arr) {
                int counter = 0;
                for (int i = 0; i < arr.Length - 1; ++i) {
                    if (arr[i] % 3 == 0 && arr[i + 1] % 3 != 0 || arr[i] % 3 != 0 && arr[i + 1] % 3 == 0) counter++;
                }
                return counter;
            }
            public static int[] CreateArrayFromFile(string filePath) {
                int[] arr;
                try {
                    if (File.Exists(filePath)) {
                        StreamReader input = new StreamReader(filePath);
                        // Принимаем количество элементов из первой строки файла
                        int n = int.Parse(input.ReadLine());
                        arr = new int[n];
                        // Заполняем массив
                        for (int i = 0; i < n; ++i) {
                            arr[i] = int.Parse(input.ReadLine());
                        }
                        input.Close();
                        return arr;
                    } else {
                        throw new Exception("The file wasn't found");
                    }
                } catch (Exception ex) { Console.WriteLine(ex.Message); }
                return null;
            }
        }
    }
}
