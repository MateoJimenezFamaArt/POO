﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoFinalPoo
{
    internal class Granjero
    {
        Clima clima = new Clima();

        public int TrabajarEnElCampo()
        {
            Console.WriteLine("Es hora de trabajar...");
            Console.WriteLine("Vas al cobertizo y debes tomar la primera decision del dia, que cosecha trabajaras el dia de hoy? ");
            Console.WriteLine("1 = Trigo /// 2 = Papa");
            int EleccionDeTrabajo = 0;
            EleccionDeTrabajo = int.Parse(Console.ReadLine());

            if (EleccionDeTrabajo == 1) { Console.WriteLine("Preparandote para salir al campo tomas la hoz, el sombrero de paja y la guadaña "); return EleccionDeTrabajo; }
            if (EleccionDeTrabajo == 2) { Console.WriteLine("Preparandote para salir al campo tomas los guantes y la azada"); return EleccionDeTrabajo; }
            else {return EleccionDeTrabajo; };
        }
        //quitar esta clase 
        public void ComprarDefensas() { }

        //public void Buscar un Vendedor() {}
        public void Vender() { }

        public void ComprarDaga() { }


    }
}
