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

            //кортеж
            (string name, int age) anketa;
            Console.Write("Представьтесь, пожалуйста: ");
            anketa.name = Console.ReadLine();
            Console.Write("Укажите свой возраст: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Подтвердите правильность информации:");
            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);

            (string Name, string Type, double Age, int NameCount) Pet;
            Console.WriteLine("Введите имя питомца");
            Pet.Name = Console.ReadLine();
            Pet.NameCount = Pet.Name.Length;

            Console.WriteLine("Введите возраст питомца");
            Pet.Age = double.Parse(Console.ReadLine());


        }
    }
}
