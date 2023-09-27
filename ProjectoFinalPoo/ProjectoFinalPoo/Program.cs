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
            TiendaDelPueblo tienda = new TiendaDelPueblo();
            Clima clima = new Clima();

            

            Console.WriteLine("Vamos a realizar la creacion de clases");
            Console.WriteLine("Hola, bienvenido a farm simulator Console Edition TM.");
            Console.WriteLine("Porfavor dime cuantos dias deseas jugar?");
            Console.WriteLine("(Se recomienda jugar unos 10 dias para experimentar el juego por completo)");
            int Daystoplay = 0;
            Daystoplay = int.Parse (Console.ReadLine());

            for (int i = 1; i < Daystoplay + 1; i++)
            {
                clima.ElegirDia();
                granjero.TrabajarEnElCampo();

            }

               
            

        }
    }


}