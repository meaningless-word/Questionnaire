using System;

namespace Questionnaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Представьтесь, пожалуйста: ");
            string name = Console.ReadLine();
            Console.Write("Укажите свой возраст: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Укажите дату рождения: ");
            var birthday = Console.ReadLine();

            Console.WriteLine("Подтвердите правильность информации:");
            Console.WriteLine($"Ваше имя {name}");
            Console.WriteLine("Дата рождения {0}", birthday);
            Console.WriteLine("Полных лет: " + age.ToString());

            Console.ReadKey();

        }
    }
}
