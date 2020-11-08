namespace MaxGiriy_Lesson05_Task04 {
    public struct Student {
        public string Name { get; private set; }
        public float Mark { get; private set; }

        public Student(string name, float mark) {
            Name = name;
            Mark = mark;
        }
    }
}