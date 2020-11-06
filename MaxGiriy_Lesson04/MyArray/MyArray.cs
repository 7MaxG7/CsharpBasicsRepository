using System;

namespace MyArrayLib {

    public class MyArray {
        int[] a;

        public MyArray(int n, int el) {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }
        public MyArray(int n, int min, int max) {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }
        public MyArray(int n, float startElem, int step) {
            a = new int[n];
            a[0] = (int)startElem;
            for (int i = 1; i < a.Length; ++i) {
                a[i] = a[i - 1] + step;
            }
        }

        public int Size {
            get { return a.Length; }
        }
        public int Max {
            get {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        public int Min {
            get {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        public int CountPositiv {
            get {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }
        public int Sum {
            get {
                int sum = 0;
                foreach (var item in a) {
                    sum += item;
                }
                return sum;
            }
        }
        public int MaxCount {
            get {
                int counter = 0;
                foreach (var item in a) {
                    if (item == Max) counter++;
                }
                return counter;
            }
        }
        public int this[int index] {
            get { return a[index]; }
        }

        public override string ToString() {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }

        public MyArray Inverse() {
            MyArray copy = new MyArray(a.Length, 0);
            for (int i = 0; i < copy.a.Length; ++i) {
                copy.a[i] = -a[i];
            }
            return copy;
        }
        public void Multi(int multiplier) {
            for (int i = 0; i < a.Length; ++i) {
                a[i] *= multiplier;
            }
        }
    }
}
