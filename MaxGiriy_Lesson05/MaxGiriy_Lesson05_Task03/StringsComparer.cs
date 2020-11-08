using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxGiriy_Lesson05_Task03 {
    public static class StringsComparer {

        /// <summary>
        /// Определяет, состоят ли слова из одних и тех же символов
        /// </summary>
        public static bool CompareStrings(string str1, string str2) {
            return Enumerable.SequenceEqual(StringSplitter(str1), StringSplitter(str2));
        }
        /// <summary>
        /// Преобразует строку в сортированный словарь символов
        /// </summary>
        static SortedDictionary<char, int> StringSplitter(string str) {
            SortedDictionary<char, int> dict = new SortedDictionary<char, int>();
            foreach (var letter in str) {
                if (!dict.ContainsKey(letter)) dict.Add(letter, 1);
                else dict[letter]++;
            }
            return dict;
        }
    }
}
