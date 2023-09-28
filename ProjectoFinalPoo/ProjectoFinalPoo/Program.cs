using System.Numerics;
using System.Threading.Channels;

namespace ProjectoFinalPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Granjero granjero = new Granjero();
            Bandidos bandidos = new Bandidos();
            Mercader mercader = new Mercader();
            Armero armero = new Armero();
            Clima clima = new Clima();

            int DiaRandom = 0;
            int EleccionCampo = 0; // 1 = trigo // 2 = papa


            //Contadores
            int Trigo = 0;
            int Papa = 0;
            int Oro = 0;
            int TieneDaga = 0; //1 - si // 2 - no

            Console.WriteLine("Vamos a realizar la creacion de clases");
            Console.WriteLine("Hola, bienvenido a farm simulator Console Edition TM.");
            Console.WriteLine("Porfavor dime cuantos dias deseas jugar?");
            Console.WriteLine("(Se recomienda jugar unos 10 dias para experimentar el juego por completo)");
            int Daystoplay = 0;
            Daystoplay = int.Parse(Console.ReadLine());

            for (int i = 1; i < Daystoplay + 1; i++)
            {
                clima.ElegirDia();
                DiaRandom = clima.ElegirDia();

                Console.WriteLine("El dia comienza brillante y radiante.");
                Console.WriteLine("Saltas de la cama con un brinco asombrante ");
                Console.WriteLine("Abres la ventana dando un suspiro impactante ");
                Console.WriteLine("Y te pones a decidir cual sera hoy tu camino errante ...");

                Console.WriteLine("1 - Trabajar en el campo");
                Console.WriteLine("2 - Ir al pueblo");
                int RespuestaDiaria = int.Parse(Console.ReadLine());

                if (RespuestaDiaria == 1) // Decidio trabajar en el campo
                {

                    EleccionCampo = granjero.TrabajarEnElCampo();


                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("El dia random fue " + DiaRandom);
                    Console.WriteLine("El return del granjero fue " + EleccionCampo);
                    Console.BackgroundColor = ConsoleColor.Black;

                    if (DiaRandom == 1 & EleccionCampo == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Enhora buena! Ha hecho un muy buen dia para crecer trigo, eso y tu gran esfuerzo ha dado frutos");
                        Trigo++;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Actualmente tienes " + Trigo + " de trigo");
                        Console.ForegroundColor = ConsoleColor.White;


                    }

                    if (DiaRandom == 2 & EleccionCampo == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Enhora buena! Ha hecho un muy buen dia para crecer papa, eso y tu gran esfuerzo ha dado frutos");
                        Papa++;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Actualmente tienes " + Papa + " de papa");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    if (DiaRandom == 1 & EleccionCampo == 2 || DiaRandom == 2 & EleccionCampo == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Vaya que mala suerte, trabajaste muy fuertemente pero el clima no te ayudo a conseguir ningun fruto");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                } // Fin de decision del campo


                if (RespuestaDiaria == 2) // Decidio ir al pueblo a comprar cosas
                {
                    Console.WriteLine("Despues de un buen desayuno te embarcas rumbo al pueblo...");
                    Console.WriteLine("Tras una caminata bastante larga logras llegar al pueblo, ahora debes decidir que quieres hacer.");
                    Console.WriteLine("1 - Para ir a la plaza del mercado a vender tu producto");
                    Console.WriteLine("2 - Para ir a donde el armero a comprpar una daga");
                    int RespuestaDePueblo = int.Parse(Console.ReadLine());

                    if (RespuestaDePueblo == 1) 
                    {
                        mercader.SolicitarProducto();
                    }
                    if (RespuestaDePueblo == 2) 
                    {
                        armero.VenderDaga();
                    }

                }




            }
        }

    }
}