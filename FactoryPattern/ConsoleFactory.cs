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
        }
        
            
            
               
    }


}

         
    
        
    
    

