using System;
namespace FactoryPattern
{
    public static class ConsoleFactory
    {
        public static IConsoles GetConsole(int controllerAmount)
        {
            switch (controllerAmount)
            {
                case 1:
                    return new PS5();
                case 2:
                    return new XboxSeriesX();
                case 3:
                    return new NintendoSwitch();
                default: return new XboxSeriesX();
            }
            //} return controllerAmount switch
            //    {
            //        1 => new PS5(),
            //        2 => new XboxSeriesX(),
            //        3 => new NintendoSwitch(),
            //        _ => new XboxSeriesX(),
            //    };
        }



    }
}



         
    
        
    
    

