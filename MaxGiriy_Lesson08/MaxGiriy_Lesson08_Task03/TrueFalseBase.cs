using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace MaxGiriy_Lesson08_Task03 {
    class TrueFalseBase {
        string fileName;
        List<Question> list;

        public TrueFalseBase(string fileName) {
            this.fileName = fileName;
            list = new List<Question>();
        }

        public string FileName { set => fileName = value; }
        public int Count { get => list.Count; }
        public bool Empty { get => list.Count == 0; }

        public void Add(string text, bool trueFalse) {
            list.Add(new Question(text, trueFalse));
        }
        public void Remove(uint index) {
            if (list != null && index < list.Count && index >= 0)
                list.RemoveAt((int)index);
        }
        public Question this[uint index] {
            get { return list[(int)index]; }
        }

        //public void Save() {
        //    XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
        //    Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
        //    xmlFormat.Serialize(fStream, list);
        //    fStream.Close();
        //}
        public void Save(string path) {
            fileName = path;
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }
        public void Load() {
            if (File.Exists(fileName)) {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
                Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                list = (List<Question>)xmlFormat.Deserialize(fStream);
                fStream.Close();
            }
        }
    }
}