namespace IntroM3
{
    internal class MyConsole
    {
        static string Ask(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }

        static int AskForInt(string question)
        {
            var answer = Ask(question);
            return Convert.ToInt32(answer);
        }
    }
}
