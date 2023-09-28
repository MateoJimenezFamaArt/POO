using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProjectoFinalPoo
{
    internal class Clima
    {   
          public int ElegirDia()
          {
                int DayChoice = 0;
                string StateDay = " ";
                Random randomDay = new Random();

                DayChoice = randomDay.Next(1,3);
            
                if (DayChoice == 1) 
                {
                    return DayChoice; 
                }
                if (DayChoice == 2) 
                { 
                return DayChoice; 
                }
                else { return DayChoice; }
                
            

        }
    }
}
