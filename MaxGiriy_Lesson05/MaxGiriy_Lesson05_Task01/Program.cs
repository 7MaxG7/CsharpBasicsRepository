using System;

namespace MaxGiriy_Lesson05_Task01 {

    //Гирий Максим
    //    1. Создать программу, которая будет проверять корректность ввода логина. Корректным
    //    логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита
    //    или цифры, при этом цифра не может быть первой:
    //    а) без использования регулярных выражений;
    //    б) ** с использованием регулярных выражений.

    class Program {

        static void Main(string[] args) {
            Console.Write("Hello, enter your login: ");
            string userLogin = Console.ReadLine();

            // Проверка логина без использования регулярных выражений
            if (LoginChecker.CkeckLogin(userLogin, CheckMethod.NoExpressions)) {
                Console.WriteLine($"Login {userLogin} is correct by method without expressions.");
            } else {
                Console.WriteLine($"Login {userLogin} is NOT correct by method without expressions.");
            }

            // Проверка логина с использованием регулярных выражений
            if (LoginChecker.CkeckLogin(userLogin, CheckMethod.RegularExpressions)) {
                Console.WriteLine($"Login {userLogin} is correct by regular expressions method.");
            } else {
                Console.WriteLine($"Login {userLogin} is NOT correct by regular expressions method.");
            }
            Console.ReadKey();
        }
    }
}
