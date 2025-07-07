namespace ELECADOR_1._0
{
    public partial class Indicador
    {
public int pisoActual;

        // Constructor que recibe el piso inicial
        public void IndicadorDePiso(int pisoInicial)
        {
            pisoActual = pisoInicial;
        }

        // Método para actualizar el piso actual
        public void actualizar(int piso)
        {
            pisoActual = piso;
            Console.WriteLine("Piso {0}",pisoActual);
        }
    }
}
