using System.Numerics;

namespace ProjectoFinalPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos a realizar la creacion de clases");
            Console.WriteLine("Hola, bienvenido a farm simulator Console Edition TM.");
            Console.WriteLine("Porfavor dime cuantos dias deseas jugar?");
            Console.WriteLine("(Se recomienda jugar unos 10 dias para experimentar el juego por completo)");
            int Daystoplay = 0;
            Daystoplay = int.Parse (Console.ReadLine());



            Granjero g1 = new Granjero();
            g1.TrabajarEnElCampo();
        }
    }
}