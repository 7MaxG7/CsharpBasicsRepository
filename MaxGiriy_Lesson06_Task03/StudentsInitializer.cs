using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace MaxGiriy_Lesson06_Task03 {
    internal static class StudentsInitializer {
        static List<Student> students;

        public static int StudetsNumber {
            get { return students.Count; }
        }

        public static void Initialize(string path) {
            students = new List<Student>();
            StreamReader sr = new StreamReader(path);
            while (!sr.EndOfStream) {
                try {
                    string[] data = sr.ReadLine().Split(',');
                    Student student = new Student(data);
                    students.Add(student);
                }
                catch {
                }
            }
            sr.Close();
            students.Sort(StudentsComparer);
            foreach (var stu in students) {
                Console.WriteLine($"{stu.Name} {stu.Course} {stu.Age}");
            }
        }

        private static int StudentsComparer(Student a, Student b) {
            return a.Course > b.Course ? 1 : a.Course < b.Course ? -1 : a.Age > b.Age ? 1 : a.Age < b.Age ? -1 : 0;
        }

        public static int GetNumberStudentsOfCourse(short course) {
            int counter = 0;
            foreach (Student stu in students) {
                if (stu.Course == course) ++counter;
            }
            return counter;
        }
        public static int[] SorterByCourse(List<Student> list) {
            int[] arr = new int[6];
            foreach (var stu in list) ++arr[stu.Course - 1];
            return arr;
        }
        public static List<Student> GetStudentsOgAge(int minAge, int maxAge) {
            List<Student> list = new List<Student>();
            foreach (Student stu in students) {
                if (stu.Age >= minAge && stu.Age <= maxAge) list.Add(stu);
            }
            return list;
        }
    }
}