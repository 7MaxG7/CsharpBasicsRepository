using System;
using System.IO;

namespace MaxGiriy_Lesson04_Task05 {

    //Гирий Максим
    //    5. * а) Реализовать библиотеку с классом для работы с двумерным массивом.Реализовать
    //    конструктор, заполняющий массив случайными числами.Создать методы, которые возвращают
    //    сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство,
    //    возвращающее минимальный элемент массива, свойство, возвращающее максимальный
    //    элемент массива, метод, возвращающий номер максимального элемента массива(через
    //    параметры, используя модификатор ref или out).
    //    ** б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные
    //    в файл.
    //    ** в) Обработать возможные исключительные ситуации при работе с файлами.

    public class TwoDimArray {
        int[,] arr;

        public TwoDimArray(int rows, int collums, int maxVal) {
            arr = new int[rows, collums];

            Random rand = new Random();
            for (int i = 0; i < arr.GetLength(0); ++i) {
                for (int j = 0; j < arr.GetLength(1); ++j) {
                    arr[i, j] = rand.Next(maxVal);
                }
            }
        }
        public TwoDimArray(int rows, int collums, string path) {
            arr = new int[rows, collums];
            FillFromFile(path);
        }

        public int Sum {
            get { return SumOfValuesGreater(int.MinValue); }
        }
        public int Min {
            get {
                int min = arr[0, 0];
                for (int i = 0; i < arr.GetLength(0); ++i) {
                    for (int j = 0; j < arr.GetLength(1); ++j) {
                        if (arr[i, j] < min) min = arr[i, j];
                    }
                }
                return min;
            }
        }
        public int Max {
            get {
                int max = arr[0, 0];
                for (int i = 0; i < arr.GetLength(0); ++i) {
                    for (int j = 0; j < arr.GetLength(1); ++j) {
                        if (arr[i, j] > max) max = arr[i, j];
                    }
                }
                return max;
            }
        }

        public int SumOfValuesGreater(int value) {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); ++i) {
                for (int j = 0; j < arr.GetLength(1); ++j) {
                    if (arr[i, j] > value) sum += arr[i, j];
                }
            }
            return sum;
        }
        public void MaxValueNumber(ref int n) {
            for (int i = 0; i < arr.GetLength(0); ++i) {
                for (int j = 0; j < arr.GetLength(1); ++j) {
                    if (arr[i, j] == Max) {
                        n = i * arr.GetLength(1) + j;
                        return;
                    }
                }
            }
        }
        public void FillFromFile(string path) {
            try {
                StreamReader input = new StreamReader(path);
                for (int i = 0; i < arr.GetLength(0); ++i) {
                    for (int j = 0; j < arr.GetLength(1); ++j) {
                        if (input.EndOfStream) {
                            throw new DataMisalignedException("Not enough of data in the file.");
                        }
                        arr[i, j] = int.Parse(input.ReadLine());
                    }
                }
            } catch (FileNotFoundException ex) { Console.WriteLine(ex.Message); }
              catch (DataMisalignedException ex) { Console.WriteLine(ex.Message); }
        }
        public void ExportToFile(string path) {
            try {
                StreamWriter output = new StreamWriter(path);
                for (int i = 0; i < arr.GetLength(0); ++i) {
                    for (int j = 0; j < arr.GetLength(1); ++j) {
                        output.WriteLine(arr[i, j]);
                    }
                }
            }
            catch (FileNotFoundException ex) { Console.WriteLine(ex.Message); }
        }
    }
}
