using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace MaxGiriy_Lesson08_Task05 {
    static class CSV_to_XML {
        static List<Student> students;
        public static void ConvertCSVtoXML(string path) {
            LoadCSV(path);
            string filename = path.Substring(0, path.LastIndexOf('.')) + ".xml";
            SaveXML(filename);
        }
        static void LoadCSV(string path) {
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
        }
        static void SaveXML(string path) {
            Stream fStream = new FileStream(path, FileMode.Create, FileAccess.Write);
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            xmlFormat.Serialize(fStream, students);
            fStream.Close();
        }
    }
}
