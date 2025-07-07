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
            // Lógica de funcionamiento del elevador
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
