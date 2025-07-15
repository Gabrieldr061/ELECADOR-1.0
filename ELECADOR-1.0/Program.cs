
namespace ELECADOR_1._0
{
    public partial class ELEVADOR
    {
        private Boton boton;
        private Indicador indicador;
        private Sensor sensor;
        private Motor motor;
        private int pisoact = 1;
        private int piso;
        
        public ELEVADOR()
        {
            boton = new Boton(true);
            indicador = new Indicador(pisoact);
            sensor = new Sensor(true);
            motor = new Motor();
        }

        public void Funcionamiento()
        {
            SensorPeso sensorPeso = new SensorPeso("55", true);
            SensorPresencia sensorPresencia = new SensorPresencia(true);
            indicadorDePiso indicadorDePiso = new indicadorDePiso(piso, pisoact);
            Botonpuerta botonpuerta = new Botonpuerta(true);
            Botonpiso botonpiso = new Botonpiso(true);


            botonpuerta.abrirPuerta();
            Console.WriteLine("------------------------------------------------------");

            if (!sensorPresencia.detectarPresencia())
            {
                botonpuerta.abrirPuerta();
                Thread.Sleep(1500);
                return;
            }

            Console.WriteLine("------------------------------------------------------");

            if (!sensorPeso.detectarPeso())
            {
                botonpuerta.abrirPuerta();
                Thread.Sleep(1500);
                return;
            }

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Piso actual: {0} ", pisoact);

            inicio:
            botonpiso.seleccionarPiso();
            piso = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (piso < 1 || piso > 5 || piso == pisoact)
            {
                Console.WriteLine("Piso no valido, por favor ingrese un piso entre 1 y 5 y que no sea el mismo.");
                goto inicio;
            }
                Console.WriteLine("------------------------------------------------------");
                botonpuerta.cerrarPuerta();
                Thread.Sleep(1000);
                motor.Encender();
                Thread.Sleep(1000);
                indicadorDePiso.actualizar(piso, pisoact);
                Thread.Sleep(1000);
                motor.Apagar();
                Thread.Sleep(1000);
                botonpuerta.abrirPuerta();
                Console.WriteLine("------------------------------------------------------");
            
            pisoact = piso;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ELEVADOR elevador = new ELEVADOR();
            inicio:
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Bienvenido");
            Console.WriteLine("------------------------------------------------------");
            Thread.Sleep(1500);

            elevador.Funcionamiento();
            Thread.Sleep(3000);
            Console.Clear();
            goto inicio;
        }
    }
}
