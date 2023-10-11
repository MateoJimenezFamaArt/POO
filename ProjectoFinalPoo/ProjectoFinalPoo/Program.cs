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
            int EleccionMercader = 0;
            string EleccionMercaderstr = " ";


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


                //Console.WriteLine("te amo yuli <3");

                //Console.WriteLine("marlon marlon marlon marlon marlon merlon merlon");

                //Console.WriteLine("jfajsdflafaosamofvnaoaofa putos  todos onaodsfnaofafqoqeer")


                Console.WriteLine("El dia comienza brillante y radiante.");
                Console.WriteLine("Saltas de la cama con un brinco asombrante ");
                Console.WriteLine("Abres la ventana dando un suspiro impactante ");
                Console.WriteLine("Y te pones a decidir cual sera hoy tu camino errante ...");

                Console.WriteLine("1 - Trabajar en el campo");
                Console.WriteLine("2 - Ir al pueblo");
                int RespuestaDiaria = int.Parse(Console.ReadLine());

                if (RespuestaDiaria == 1) // Decidio trabajar en el campo
                {

                    EleccionCampo = granjero.TrabajarCampo();


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
                        Console.WriteLine("Con determinacion te diriges hacia la plaza de mercado del pueblo");
                        Console.WriteLine("Pasas de puesto en puesto viendo como hay un poco de todo, desde carpinteros hasta artefactos magicos");
                        Console.WriteLine("Luego de una buena caminata llegas al lugar que tanto estuviste esperando...");
                        Thread.Sleep(1000);
                        Console.WriteLine("El puesto de compraventa de bienes agricolas");
                        Console.WriteLine("Te acercas al puesto principal en donde le preguntas al tendero que productos estan solicitando hoy?");
                        EleccionMercader = mercader.SolicitarProducto();
                        Console.ForegroundColor= ConsoleColor.DarkBlue;
                        if(EleccionMercader == 1) { EleccionMercaderstr = "trigo"; }
                        if (EleccionMercader == 2) { EleccionMercaderstr = "papa"; }
                        Console.WriteLine("Hola señor agricola como te encuentras el dia de hoy? En el momento estoy revisando inventario y nos hace falta un poco de " + EleccionMercaderstr);
                        Console.WriteLine("Dejame ver tu inventario a ver como estas de recursos");

                        //Inventario b4
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("INVENTARIO ANTES DE INTERACTUAR");
                        Console.WriteLine("TRIGO -> " + Trigo);
                        Console.WriteLine("PAPA -> " + Papa);
                        Console.WriteLine("ORO -> " + Oro);
                        Console.ForegroundColor = ConsoleColor.White;

                        if (EleccionMercader == 1 & Trigo != 0)
                        { 
                            Console.WriteLine("Veo que si tienes un poco de trigo para venderme, que dices hacemos un trato?");
                            Console.WriteLine("1 - Si");
                            Console.WriteLine("2 - No");
                            int RespuestadeVender = int.Parse(Console.ReadLine());

                            if (RespuestadeVender == 1) { granjero.Vender();Trigo--; Oro++; } //Issue Inverse Logic
                            if (RespuestadeVender == 2) { Console.WriteLine("Ohhh esta bien, entiendo vuelve cuando quieras vender y aca te recibiremos."); }

                        }
                        if (EleccionMercader == 2 & Papa != 0)
                        { 
                            Console.WriteLine("Veo que si tienes un poco de papa para venderme, que dices hacemos un trato?");
                            int RespuestadeVender = int.Parse(Console.ReadLine());

                            if (RespuestadeVender == 1) { granjero.Vender(); Papa --; Oro++; } //Issue Inverse Logic
                            if (RespuestadeVender == 2) { Console.WriteLine("Ohhh esta bien, entiendo vuelve cuando quieras vender y aca te recibiremos."); }
                                                                                                                                                             
                        }

                        //Inventario a4
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("INVENTARIO DESPUES DE INTERACTUAR");
                        Console.WriteLine("TRIGO -> " + Trigo);
                        Console.WriteLine("PAPA -> " + Papa);
                        Console.WriteLine("ORO -> " + Oro);
                        Console.ForegroundColor = ConsoleColor.White;





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