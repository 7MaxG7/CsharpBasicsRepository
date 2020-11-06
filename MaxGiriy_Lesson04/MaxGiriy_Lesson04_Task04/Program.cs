using System;
using System.IO;
using System.Xml;

namespace MaxGiriy_Lesson04_Task04 {

    //Гирий Максим
    //    4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
    //    Создайте структуру Account, содержащую Login и Password.

    class Program {

        static void Main(string[] args) {
            Account correctAccount = new Account("root", "GeekBrains");

            string[] login = new string[2];
            StreamReader input = new StreamReader("login.txt");

            int tryNumber = 0, maxTryNumber =3 ;
            do {
                tryNumber++;
                if (tryNumber > maxTryNumber) {
                    Console.WriteLine("\nAuthorization failed.");
                    input.Close();
                    return;
                }
                if (tryNumber == 1) {
                    Console.WriteLine("Hello! Complete authorization to run the program.");
                } else {
                    Console.WriteLine("\nAuthorization error. Try again.");
                }
                login[0] = input.ReadLine();
                login[1] = input.ReadLine();
            } while (login[0] != correctAccount.Login || login[1] != correctAccount.Password);

            input.Close();
            Console.WriteLine("\nAuthorization completed!");
            Console.ReadKey();
        }

        struct Account {
            public string Login { get; private set; }
            public string Password { get; private set; }

            public Account(string login, string password) {
                Login = login;
                Password = password;
            }
        }
    }
}
