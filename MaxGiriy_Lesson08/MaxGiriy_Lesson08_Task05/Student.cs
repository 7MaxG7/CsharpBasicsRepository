using System;

namespace MaxGiriy_Lesson08_Task05 {
    public class Student {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Univercuty { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }
        public short Course { get; set; }
        public int Group { get; set; }
        public string City { get; set; }
        public Student() {
        }
        public Student(string[] data) {
            Name = data[0];
            Surname = data[1];
            Univercuty = data[2];
            Faculty = data[3];
            Department = data[4];
            Age = int.Parse(data[5]);
            Course = short.Parse(data[6]);
            City = data[7];
        }
    }
}