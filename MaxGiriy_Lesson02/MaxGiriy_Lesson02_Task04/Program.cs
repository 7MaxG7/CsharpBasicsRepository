using System;

namespace MaxGiriy_Lesson02_Task04 {

    //    Гирий Максим
    //        Реализовать метод проверки логина и пароля.На вход метода подается логин и пароль. На
    //выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password:
    //GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь
    //вводит логин и пароль, программа пропускает его дальше или не пропускает.С помощью
    //цикла do while ограничить ввод пароля тремя попытками.

    class Program {
        static void Main(string[] args) {
            string correctLogin = "root", correctPass = "GeekBrains";

            int tryNumber = 0, maxTryNumber =3 ;
            do {
                tryNumber++;
                if (tryNumber > maxTryNumber) return;
                if (tryNumber == 1) {
                    Console.WriteLine("Hello! Complete authorization to run the program.");
                } else {
                    Console.WriteLine("\nAuthorization error. Try again.");
                }
            } while (!AuthorizationCheck(correctLogin, correctPass));

            Console.WriteLine("\nAuthorization completed!");
            Console.ReadKey();
        }
        static bool AuthorizationCheck(string correctLogin, string correctPass) {
            Console.Write("\tLogin: ");
            string userLogin = Console.ReadLine();
            Console.Write("\tPassword: ");
            string userPass = Console.ReadLine();
            return userLogin == correctLogin && userPass == correctPass;
        }
    }
}
