using System;

namespace FactoryPattern
{
    class MainClass
    {
         static void Main(string[] args)
        {
            int controllerAmount;
            bool input = false;
            do
            {
                Console.WriteLine("Enter the amount of controllers you'd like for your console.");
                 input = int.TryParse(Console.ReadLine(), out controllerAmount);
            } while (!input);

            var newConsole = ConsoleFactory.GetConsole(controllerAmount);
            newConsole.TurnOn();
        }
    }
}
