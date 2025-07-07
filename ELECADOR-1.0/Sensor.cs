namespace ELECADOR_1._0
{
    public partial class Sensor
    {
        public bool detectarPeso()
        {
            Console.WriteLine("Ingrese el peso actual del elevador en Kg: ");
            string pesoActual = Console.ReadLine();
            float pesoActualNum = Convert.ToSingle(pesoActual);

            if (pesoActualNum >= 700)
            {
                Console.WriteLine("Peso no permitido, excede limite de peso");
                Console.WriteLine("¡Favor de bajar una persona o quitar peso del elevador!");
                return false;
            }

            else
            {
                Console.WriteLine("Peso no permitido, excede limite de peso");
                Console.WriteLine("¡Favor de bajar una persona o quitar peso del elevador!");
                return true;
            }
        }
    }
}
