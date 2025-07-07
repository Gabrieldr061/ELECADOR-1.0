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
            Console.WriteLine("Bienvenido");
            Thread.Sleep(1500);
            Console.Clear();

            Sensor sensor = new Sensor();
            Indicador indicador = new Indicador();

            if (!sensor.detectarPeso())
            {
                Console.WriteLine("Error: elevador en sobrepeso, operación detenida.");
                return; // Detiene el programa si está en sobrepeso
            }

            Console.WriteLine("Elevador funcionará correctamente.");
            Console.WriteLine("------------------------------------------------------");

            indicador.IndicadorDePiso(pisoact);
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("A QUE PISO QUIERES IR?");
            Console.WriteLine("1...\n2...\n3...\n4...\n5...");
            
            piso = Convert.ToInt32(Console.ReadLine());
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

           

            motor.Encender();
            Console.WriteLine($"Yendo al piso {piso}...");
            Thread.Sleep(2000); // Simula el tiempo de viaje
            motor.Apagar();
            Thread.Sleep(1000); // Simula el frenado
            Console.WriteLine("Elevador detenido.");

            indicador.actualizar(piso);
            pisoact = piso;
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
