using System.Security.Cryptography.X509Certificates;

namespace ELECADOR_1._0
{
    public partial class ELEVADOR
    {
        private Boton boton;
        private Boton.Botonpuerta botonPuerta;
        private Boton.Botonpiso botonPiso; 
        private Indicador indicador;
        private Sensor sensor;
        private Motor motor;

        int pisoact = 1;
        int piso;
        
        public ELEVADOR()
        {
            botonPuerta = new Boton.Botonpuerta(false); // botón de puerta inicia no presionado
            botonPiso = new Boton.Botonpiso(false); // piso=0, actual=1, no presionado
            indicador = new Indicador();
            sensor = new Sensor();
            motor = new Motor();
        }

        public void Funcionamiento()
        {
            Console.WriteLine("Bienvenido");
            Console.WriteLine("------------------------------------------------------");
            Thread.Sleep(1500);
            botonPuerta.abrirPuerta();
            Console.WriteLine("------------------------------------------------------");
            if (!sensor.detectarPeso())
            {
                Console.WriteLine("Error: elevador en sobrepeso, operación detenida.");
                botonPuerta.abrirPuerta();
                return;
            }
            
            Console.WriteLine("Elevador funcionará correctamente.");
            Console.WriteLine("------------------------------------------------------");
            indicador.IndicadorDePiso(pisoact);
            botonPiso.seleccionarPiso(piso, pisoact);
            Console.Clear();
            Console.WriteLine("------------------------------------------------------");
            botonPuerta.cerrarPuerta();
            Thread.Sleep(1000);
            motor.Encender();
            Thread.Sleep(1000);
            Console.WriteLine("Yendo al piso {0}...",piso);
            Thread.Sleep(1000);
            indicador.actualizar(piso);
            Thread.Sleep(1000);
            motor.Apagar();
            Thread.Sleep(1000);
            Console.WriteLine("Elevador detenido...");
            Thread.Sleep(1000);
            botonPuerta.abrirPuerta();
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
