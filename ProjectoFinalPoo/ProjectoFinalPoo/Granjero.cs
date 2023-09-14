using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinalPoo
{
    internal class Granjero
    {
        public void TrabajarEnElCampo()
        {
            Console.WriteLine("El sol ya ha salido, te das una buena estirada y te preparas para salir al campo");
            Console.WriteLine("Con un fuerte suspiro te levantas y vislumbras el campo, ha llegado el momento.");
            Console.WriteLine("Es hora de trabajar...");
            Console.WriteLine("Vas a preparar el campo para trabjar en Trigo o en Papas?");
            Console.WriteLine("1 = SI /// 2 = NO");
            int InstantResponse = 0;
            InstantResponse = int.Parse(Console.ReadLine());

            if(InstantResponse != 1 || InstantResponse != 2) { Console.WriteLine("Porfavor haz un input congruente"); InstantResponse = int.Parse(Console.ReadLine());}
            if (InstantResponse == 1) { Console.WriteLine("Preparandote para salir al campo tomas la hoz para trabajar en trigos lo jornada sera larga pero valdra la pena."); }
            if (InstantResponse == 2) { Console.WriteLine("Preparandote para salir al campo tomas los guantes y la azada para salir a trabajar en las papas, la jornada sera larga pero valdra la pena"); }

        }

    }
}
