namespace ELECADOR_1._0
{
    public partial class Sensor
    {
        public bool detectarPeso() //funcion para detectar el peso en el elevador
        {
            int pesoActual = (600);
            Console.WriteLine("El peso del elevador es {0}kg",pesoActual); //aqui ingresas cuanto peso el que hay en el elevador
            float pesoActualNum = Convert.ToSingle(pesoActual); //conversion a flotante el peso

            if (pesoActualNum >= 700) //si el peso es mayor o igual, se ejecuta (no puede continuar el elevador)
            {
                Console.WriteLine("Peso no permitido, {0} kg, excede limite de peso",pesoActualNum);
                float pesoExcedente = 700 - pesoActualNum;
                Console.WriteLine("¡Favor de bajar una persona o quitar {0} Kg del elevador!",pesoExcedente);
                return false;
            }

            else //si el peso esta dentro del limite permitido puede ejecutarse 
            {
                Console.WriteLine("Peso permitido, el elevador puede continuar");
                return true;
            }
        }
    }
}
