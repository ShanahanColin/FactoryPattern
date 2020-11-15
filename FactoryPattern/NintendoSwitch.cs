using System;
namespace FactoryPattern
{
    public class NintendoSwitch : IConsoles
    {
        public NintendoSwitch()
        {
        }

        public void TurnOn()
        {
            ConsoleLogger.ConsoleSwitchOnDialogue();
            Console.WriteLine("Nintendo is turning on");
        }
    }
}
