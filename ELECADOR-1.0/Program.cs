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
        public void Funcionamiento()
        {
            Console.WriteLine("Bienvenido");
            Thread.Sleep(1500);
            Console.Clear();

            //.......<SENSOR ANGEL>.........

            Sensor sensor = new Sensor();
            Indicador indicador = new Indicador();

            if (!sensor.detectarPeso())
            {
                Console.WriteLine("Error: elevador en sobrepeso, operación detenida.");
                return; // Detiene el programa si está en sobrepeso
            }

            Console.WriteLine("Elevador funcionará correctamente.");
            Console.WriteLine("------------------------------------------------------");

            //.......<FIN DEL SENSOR>.......

            indicador.IndicadorDePiso(pisoact);
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("A QUE PISO QUIERES IR?");
            Console.WriteLine("1...\n2...\n3...\n4...\n5...");
            
            piso = Convert.ToInt32(Console.ReadLine());
          
            Console.Clear();

            if (piso == pisoact)
            {
                Console.WriteLine("Ya estás en el piso ingresado \n Ingresa otro piso");
               
                return;

            }
            if (piso == 1)
            {
                
                indicador.actualizar(piso);
                pisoact = piso;

            } 
            if (piso == 2)
            {
                indicador.actualizar(piso);
                    pisoact = piso;


            }
           
            if (piso == 3)
            {
                indicador.actualizar(piso);
                pisoact = piso;
            }
            
            if (piso == 4)
            {
                indicador.actualizar(piso);
                pisoact = piso;
            }
           
            if (piso == 5)
            {
                indicador.actualizar(piso);
                pisoact = piso;

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
            Thread.Sleep(3000);
            Console.Clear();
            goto inicio;

        }
    }
}
