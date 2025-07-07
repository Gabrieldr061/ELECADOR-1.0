namespace ELECADOR_1._0
{
    public partial class ELEVADOR
    {
        private Boton boton;
        private Indicador indicador;
        private Sensor sensor;
        private Motor motor;

        public void Funcionamiento()
        {
            Console.WriteLine("Bienvenido");
            Thread.Sleep(1500);
            Console.Clear();

            //.......<SENSOR ANGEL>.........

            Sensor sensor = new Sensor();

            if (!sensor.detectarPeso())
            {
                Console.WriteLine("Error: elevador en sobrepeso, operación detenida.");
                return; // Detiene el programa si está en sobrepeso
            }

            Console.WriteLine("Elevador funcionará correctamente.");
            Console.WriteLine("------------------------------------------------------");

            //.......<FIN DEL SENSOR>.......

            Console.WriteLine("A QUE PISO QUIERES IR?");
            Console.WriteLine("1...\n2...\n3...\n4...\n5...");
            int piso = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (piso == 1)
            {
                Console.WriteLine("Yendo al piso 1...");

            } 
            if (piso == 2)
            {

                Console.WriteLine("Yendo al piso 2...");

            }
            if (piso == 3)
            {

                Console.WriteLine("Yendo al piso 3...");
            }
            if (piso == 4)
            {

                Console.WriteLine("Yendo al piso 4...");
            }
            if (piso == 5)
            {

                Console.WriteLine("Yendo al piso 5...");
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
            inicio:
            elevador.Funcionamiento();
            Thread.Sleep(5000);
            goto inicio;

        }
    }
}
