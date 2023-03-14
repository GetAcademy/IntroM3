namespace IntroM3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = MyConsole.Ask("Hva heter du? ");
            Console.WriteLine($"Hei, {name}!");

            int year= MyConsole.AskForInt("I hvilket år er du født? ");
            int age = 2023 - year;
            Console.WriteLine($"Da er du {age} år gammel.");
        }
    }
}