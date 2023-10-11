using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinalPoo
{
    internal class Mercader:IHumanos
    {

        public int SolicitarProducto() 
        {
            int ProductNeeded = 0;
            Random randomDay = new Random();

            ProductNeeded = randomDay.Next(1, 3);

            if (ProductNeeded == 1) // 1 = Trigo
            {
                return ProductNeeded;
            }
            if (ProductNeeded == 2) // 2 = Papa
            {
                return ProductNeeded;
            }
            else { return ProductNeeded; }
        }

        public void ComprarProducto() { }


    }
}
