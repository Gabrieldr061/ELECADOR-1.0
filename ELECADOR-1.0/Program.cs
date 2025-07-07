using System.Security.Cryptography.X509Certificates;

namespace ELECADOR_1._0
{
    public partial class ELEVADOR
    {
        private Boton boton;
        private Indicador indicador;
        private Sensor sensor;
        private Motor motor;

        int pisoact = 1;
        int piso;
        
        public ELEVADOR()
        {
            boton = new Boton();
            indicador = new Indicador();
            sensor = new Sensor();
            motor = new Motor();
        }

        public void Funcionamiento()
        {
            boton.abrirPuerta();
            Console.WriteLine("Bienvenido");
            Console.WriteLine("------------------------------------------------------");
            Thread.Sleep(1500);
            if (!sensor.detectarPeso())
            {
                Console.WriteLine("Error: elevador en sobrepeso, operación detenida.");
                boton.abrirPuerta();
                return;
            }
            
            Console.WriteLine("Elevador funcionará correctamente.");
            Console.WriteLine("------------------------------------------------------");
            indicador.IndicadorDePiso(pisoact);
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("A QUE PISO QUIERES IR?");
            Console.WriteLine("...1...\n...2...\n...3...\n...4...\n...5...");
            Console.WriteLine("------------------------------------------------------");
            piso = Convert.ToInt32(Console.ReadLine());
            boton.cerrarPuerta();
            Console.Clear();

            if (piso < 1 || piso > 5)
            {
                Console.WriteLine("Piso no valido, por favor ingrese un piso entre 1 y 5.");
                return;
            }

            if (piso == pisoact)
            {
                Console.WriteLine("Ya estás en el piso ingresado \n Ingresa otro piso");
                return;
            }

            Console.WriteLine("------------------------------------------------------");
            motor.Encender();
            Thread.Sleep(1000);
            Console.WriteLine("Yendo al piso {0}...",piso);
            Thread.Sleep(1000);
            indicador.actualizar(piso);
            Thread.Sleep(1000);
            motor.Apagar();
            Thread.Sleep(1000);
            Console.WriteLine("Elevador detenido...");
            boton.abrirPuerta();
            pisoact = piso;
            Console.WriteLine("------------------------------------------------------");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ELEVADOR elevador = new ELEVADOR();
            inicio:
            elevador.Funcionamiento();
            Thread.Sleep(3000);
            Console.Clear();
            goto inicio;
        }
    }
}
