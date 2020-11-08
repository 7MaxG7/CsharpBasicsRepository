using System;
using System.IO;
using System.Linq;

namespace MaxGiriy_Lesson05_Task04 {
    public class ExamsData {
        Student[] students;

        public ExamsData(string path) {
            StreamReader input = new StreamReader(path);
            // Инициализируем массив студентов по количеству в файле
            int studentsNumber = int.Parse(input.ReadLine());
            students = new Student[studentsNumber];
            // Парсим данные каждого студента в структуру и добавляем в массив
            for (int i = 0; i < studentsNumber; ++i) {
                string[] student = input.ReadLine().Split(' ');
                string name = $"{student[0]} {student[1]}";
                float mark = (int.Parse(student[2]) + int.Parse(student[3]) + int.Parse(student[4])) / 3f;
                students[i] = new Student(name, mark);
            }
            input.Close();
        }
        public void PrintWorstStudents(int numberToPrint) {
            // Создаем массив студентов к выводу на экран
            Student[] studentsToPrint = new Student[students.Length];
            // Ищем указанное число студентов с худшими оценками и добавляем в массив, отслеживая, чтобы не было дублей в случае одинаковых худших оценок
            for (int i = 0; i < numberToPrint; i++) {
                Student minMark = new Student("", float.MaxValue);
                for (int j = 0; j < students.Length; j++) {
                    if (students[j].Mark < minMark.Mark && !studentsToPrint.Contains(students[j])) minMark = students[j];
                }
                studentsToPrint[i] = minMark;
            }
            // Ищем студентов с таким же баллом, как последний записанный, также добавляем их в массив (увеличиваем счетчик студентов к выводу на экран)
            for (int i = 0; i < students.Length; i++) {
                if (students[i].Mark == studentsToPrint[numberToPrint - 1].Mark && !studentsToPrint.Contains(students[i])) {
                    studentsToPrint[numberToPrint] = students[i];
                    ++numberToPrint;
                }
            }
            // Выводим худших студентов из массива по счетчику студентов к выводу на экран
            for (int i = 0; i < numberToPrint; i++) {
                Console.WriteLine(studentsToPrint[i].Name);
            }
        }
    }
}