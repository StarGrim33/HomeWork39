namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string importantInfo = "qwerty123456";
            string password = "babyonmoretime";
            int tryCount = 3;
            string userInput;

            for (int i = 0; i < tryCount; i ++)
            {
                Console.WriteLine("Введите пароль для доступа к секретной информации: ");
                userInput = Console.ReadLine();

                if (userInput == password)
                {
                    Console.WriteLine("Пароль для доступа к секретной инфрмации: " + importantInfo);
                    break;
                }

                else
                {
                    Console.WriteLine("У вас осталось " + (tryCount - i - 1) + " попыток");
                }
            }
        }
    }
}