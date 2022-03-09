using System;

namespace PetProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для подбора фильмов!");
            string genre = Console.ReadLine();
            Console.WriteLine("Рекомендую следующие фильмы: ");

            if(genre == "Комедия")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Иван Васильевич меняет профессию.");
                Console.WriteLine("Моя прекрасная няня");
            }
            else if(genre == "Фантастика")
            {
                Console.WriteLine("Приключения Электроника");
                Console.WriteLine("Люди Икс");
            }
            else
            {
                Console.WriteLine("Зеленая миля");
                Console.WriteLine("В бой идут одни старики");
            }
        }
    }
}
