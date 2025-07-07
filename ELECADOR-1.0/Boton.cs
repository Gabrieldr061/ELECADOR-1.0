namespace ELECADOR_1._0
{
    public partial class Boton
    {
        public bool estadoPuerta;

        public void abrirPuerta()
        {
            estadoPuerta = true;
            Console.WriteLine("*Puerta esta abierta...*");
        }

        public void cerrarPuerta()
        {
            estadoPuerta = false;
            Console.WriteLine("*Puerta esta cerrada...*");
        }
    }
}
