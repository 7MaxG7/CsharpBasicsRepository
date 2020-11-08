using System;

namespace MaxGiriy_Lesson05_Task02 {

    //Гирий Максим
    //    2. Разработать статический класс Message, содержащий следующие статические методы для
    //    обработки текста:
    //    а) Вывести только те слова сообщения, которые содержат не более n букв.
    //    б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    //    в) Найти самое длинное слово сообщения.
    //    г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    //    д) *** Создать метод, который производит частотный анализ текста.В качестве параметра в
    //    него передается массив слов и текст, в качестве результата метод возвращает сколько раз
    //    каждое из слов массива входит в этот текст.Здесь требуется использовать класс Dictionary.

    class Program {

        static void Main(string[] args) {
            Console.Write("Hello, enter the message: ");
            string message = Console.ReadLine();
            Console.WriteLine();

            // Проверка функционала класса из задания
            Message.PrintWordsShorter(message, 4);
            char badEnding = 'a';
            Message.DeleteWordsEnding(ref message, badEnding);
            Console.WriteLine($"Mesage after deleting {badEnding}: {message}");
            Console.WriteLine($"First the longest word of message: {Message.GetLongestWord(message)}");
            Console.WriteLine($"All the longest words of message: {Message.AllLongestWords(message)}");
            string[] countingWords = { "abc", "qwerty", "zxc" };
            Console.WriteLine($"Counting words in text: {Message.FrequencyTextAnalysis(countingWords, message)}");

            Console.ReadKey();
        }
    }
}
