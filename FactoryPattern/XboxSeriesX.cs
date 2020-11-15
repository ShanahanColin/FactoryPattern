using System;
namespace FactoryPattern
{
    public class XboxSeriesX : IConsoles
    {
        public XboxSeriesX()
        {
           
        }

        public void TurnOn()
        {
            ConsoleLogger.ConsoleSwitchOnDialogue();
            Console.WriteLine("SeriesX is turning on");

        }
    }
}
