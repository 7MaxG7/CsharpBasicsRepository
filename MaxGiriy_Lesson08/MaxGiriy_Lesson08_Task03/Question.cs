using System;

namespace MaxGiriy_Lesson08_Task03 {
    [Serializable]
    public class Question {
        private string text; // Текст вопроса
        private bool trueFalse; // Правда или нет

        public string Text { get => text; set => text = value; }
        public bool TrueFalse { get => trueFalse; set => trueFalse = value; }

        // Здесь мы нарушаем правила инкапсуляции и эти поля нужно было бы реализовать через открытые свойства, но для упрощения примера оставим так
        // Вам же предлагается сделать поля закрытыми и реализовать открытые свойства Text и TrueFalse
        // Для сериализации должен быть пустой конструктор.
        public Question() {
        }
        public Question(string text, bool trueFalse) {
            this.text = text;
            this.trueFalse = trueFalse;
        }
    }
}