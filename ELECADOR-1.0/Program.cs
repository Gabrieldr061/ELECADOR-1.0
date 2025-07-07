namespace ELECADOR_1._0
{
    public partial class ELEVADOR
    {
        private Boton boton;
        private Indicador indicador;
        private Sensor sensor;
        private Motor motor;

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
            Console.Clear();
            Console.WriteLine("A QUE PISO QUIERES IR?");
            Console.WriteLine("1...\n2...\n3...\n4...\n5...");
            int piso = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (piso == 1)
            {
                Console.WriteLine("Saliendo del elevador...");
                return;
            } 
            if (piso == 2)
            {
                Console.WriteLine("Subiendo al segundo piso...");
                return;
            }
            if (piso == 3)
            {
                Console.WriteLine("Subiendo al tercer piso...");

                return;
            }
            if (piso == 4)
            {
                Console.WriteLine("Subiendo al cuarto piso...");

                return;
            }
            if (piso == 5)
            {
                Console.WriteLine("Subiendo al quinto piso...");

                return;
            }

            if (piso < 1 || piso > 5)
            {
                Console.WriteLine("Piso no valido, por favor ingrese un piso entre 1 y 5.");
                return;
            }
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ELEVADOR elevador = new ELEVADOR();
            elevador.Funcionamiento();

        }
    }
}
