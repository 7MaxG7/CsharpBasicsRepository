using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;

namespace MaxGiriy_Lesson05_Task02 {
    public static class Message {

        /// <summary>
        /// Выводит слова не длиннее указанного ограничения
        /// </summary>
        public static void PrintWordsShorter(string message, int length) {
            // бьем строку на массив слов, проверяем их длину и выводим при соблюдении условия
            string[] splitedMessage = message.Split(' ');
            Console.Write($"Words of message not longer than {length} words: ");
            foreach (var item in splitedMessage) {
                if (item.Length <= length) Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Удаляет из сообщения слова, заканчивающиеся на указанный символ
        /// </summary>
        public static void DeleteWordsEnding(ref string message, char symbol) {
            string newMessage = "";
            Regex regex = new Regex($"{symbol}$");
            foreach (var word in message.Split(' ')) {
                if (!regex.IsMatch(word)) newMessage += word + " ";
            }
            message = newMessage;
        }
        /// <summary>
        /// Возвращает самое длинное слово сообщения (при нескольких длинных словах с одинаковой длиной возвращает первое).
        /// </summary>
        public static string GetLongestWord(string message) {
            string longestWord = "";
            foreach (var word in message.Split(' ')) {
                if (word.Length > longestWord.Length) longestWord = word;
            }
            return longestWord;
        }
        /// <summary>
        /// Возвращает самые длинные слова сообщения (все, если их несколько)
        /// </summary>
        public static string AllLongestWords(string message) {
            int maxLength = GetLongestWord(message).Length;
            StringBuilder strBuilder = new StringBuilder();
            foreach (var word in message.Split(' ')) {
                if (word.Length == maxLength) strBuilder.Append(word + " ");
            }
            return strBuilder.ToString();
        }
        /// <summary>
        /// Возвращает строку с расчетом числа вхождений указанных слов во введенный текст
        /// </summary>
        public static string FrequencyTextAnalysis(string[] words, string text) {
            // Заполняем словарь указанными словами
            Dictionary<string, int> frequencyCounter = new Dictionary<string, int>();
            foreach (var word in words) {
                frequencyCounter.Add(word, 0);
            }
            // Бьем текст на слова и увеличиваем счетчик, если слово есть в словаре
            foreach (var word in text.Split(' ')) {
                if (frequencyCounter.ContainsKey(word)) frequencyCounter[word]++;
            }
            // Конвертируем словарь в строку и возвращаем
            string str_tmp = "";
            foreach (var item in frequencyCounter) {
                str_tmp += $"{item.Key} - {item.Value}, ";
            }
            return str_tmp;
        }
    }
}
