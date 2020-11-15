using System;
namespace FactoryPattern
{
    public class PS5 : IConsoles
    {
        public PS5()
        {
         
        }

        public void TurnOn()
        {
            ConsoleLogger.ConsoleSwitchOnDialogue();
            Console.WriteLine("PlayStation is turning on");
        }
    }
}
