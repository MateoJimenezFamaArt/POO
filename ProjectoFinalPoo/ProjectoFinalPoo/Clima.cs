using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProjectoFinalPoo
{
    internal class Clima
    {   
          public void ElegirDia()
          {
                int DayChoice = 0;
                string StateDay = " ";
                Random randomDay = new Random();

                DayChoice = randomDay.Next(1,3);
            /*
                if (DayChoice == 1) { StateDay = "soleado y muy fertil para espigas"; }
                if (DayChoice == 2) { StateDay = "algo nublado y frio para tuberculos"; }

                Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("El sol naciendo en el horizonte se posa sobre las nubes y dicta que el dia de hoy sera un dia " + StateDay);
            */

        }
    }
}
