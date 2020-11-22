using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxGiriy_Lesson08_Task03 {
    class Adapter {
        TrueFalseBase db;
        ITrueFalse inter;

        public Adapter(ITrueFalse inter) {
            this.inter = inter;
        }
        public int Count { get => db.Count; }

        public bool AddNewQuestion() {
            if (db == null || inter.Quest == string.Empty)
                return false;
            db.Add(inter.Quest, inter.TrueFalse);
            return true;
        }
        public void RemoveQuestion() {
            if (db != null)
                db.Remove(inter.QuestNumber - 1);
        }
        public void ChangeQuestion() {
            if (db != null && !db.Empty) {
                db[inter.QuestNumber - 1].Text = inter.Quest;
                db[inter.QuestNumber - 1].TrueFalse = inter.TrueFalse;
            }
        }
        public Question GetQuestion() {
            if (db != null && !db.Empty)
                return db[inter.QuestNumber - 1];
            return new Question();
        }
        public void CreateDb() {
            db = new TrueFalseBase(inter.FileName);
        }
        public bool SaveDb() {
            if (db == null)
                return false;
            db.Save(inter.FileName);
            return true;
        }
        public bool LoadDb() {
            try {
                db = new TrueFalseBase(inter.FileName);
                db.Load();
            } catch (Exception) { return false; }
            return true;
        }
    }
}
