namespace ELECADOR_1._0
{
    public partial class Indicador
    {

        // Constructor que recibe el piso inicial
        public void IndicadorDePiso(int pisoInicial)
        {
          
            Console.WriteLine("Piso actual {0}",pisoInicial);
        }

        // Método para actualizar el piso actual
        public void actualizar(int piso)
        {

            Console.WriteLine("Llegando al Piso {0}...", piso);


        }
    }
}
