using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        private static char[] _wordDictionary 
            = new char[]{ 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я',
            '@', '#', '$', '%', '&', '?', '(', ')', '[', ']', '{', '}', '=', '+', '-', '*', '/', '|', '\\', '`', '~', '"', '\'', '^', '!', '?', '.', ',', ':', ';', '_'};

        // V * T / P = 30 000 000
        private static int P = 10 ^ -5; // Степень вероятности взлома
        private static int V = 10 * 30; // 10 паролей/день и месяц
        private static int A { get => _wordDictionary.Count(); } // мощность алфавита == 64 ~ L = 4
        private static int L = 4;


        static void Main(string[] args)
        {
            var random = new Random();

            string userChoice = "";
            Console.WriteLine("Если хотите завершить работу - введите exit: ");
            int passwordNumber = 1;
            while (userChoice != "exit") 
            {
                string newPassword = "";
                for (int i = 0; i < L; i++)
                {
                    newPassword += _wordDictionary[random.Next(_wordDictionary.Count()-1)];
                }
                Console.Write($"Сгенерированный пароль #{passwordNumber++}: {newPassword} ");
                userChoice = Console.ReadLine();
            }
        }
    }
}