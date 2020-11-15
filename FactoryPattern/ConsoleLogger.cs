using System;
using System.Threading;

namespace FactoryPattern
{
    public class ConsoleLogger
    {
        public static void ConsoleSwitchOnDialogue()
        {
            Console.WriteLine("Press startup button");
            Thread.Sleep(1000);
            Console.WriteLine("Turn on controller");
            Thread.Sleep(1000);
        }
        
    
    }
}
