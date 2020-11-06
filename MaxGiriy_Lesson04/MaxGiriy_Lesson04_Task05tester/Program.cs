using System;
using MaxGiriy_Lesson04_Task05;

namespace MaxGiriy_Lesson04_Task05tester {

    class Program {

        static void Main(string[] args) {
            TwoDimArray arr = new TwoDimArray(3, 4, 20);
            arr.Print();
            Console.WriteLine();
            Console.WriteLine(arr.Sum);
            Console.WriteLine(arr.SumOfValuesGreater(10));
            Console.WriteLine(arr.Min);
            Console.WriteLine(arr.Max);

            int maxNum = 0;
            arr.MaxValueNumber(ref maxNum);
            Console.WriteLine(maxNum);
            Console.WriteLine();

            arr = new TwoDimArray(3, 4, "array.txt");
            arr.Print();
        }
    }
}
