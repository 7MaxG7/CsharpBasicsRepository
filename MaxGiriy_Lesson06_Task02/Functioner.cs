using System.IO;

namespace MaxGiriy_Lesson06_Task02 {
    static class Functioner {
        public delegate double Foo(double x);

        public static void SaveFunc(string fileName, Foo foo, double a, double b, double h) {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b) {
                bw.Write(foo(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName) {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++) {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
        public static double[] LoadWithArray(string fileName, ref double min) {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            long arrSize = fs.Length / sizeof(double);
            double d;
            double[] arr = new double[arrSize];
            for (int i = 0; i < arrSize; i++) {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                arr[i] = d;
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return arr;
        }
    }
}
