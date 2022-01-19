namespace Task1
{
    #region

    using System;

    #endregion

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("What's your name? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"Hello, {name}, today is {date.ToString("dd.MM.yyyy")} ");

            Console.WriteLine("Press 'ENTER' for exit");
            Console.Read();
        }
    }
}