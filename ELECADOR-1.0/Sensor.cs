namespace ELECADOR_1._0
{
   
    //---------------------Polimorfismo---------------

    public abstract class Sensor
    {
        public bool ValorSensor { get; set; } //propiedad publica con get y set para acceder al estado del sensor

        public Sensor(bool valorSensor) //constructor base que recibe el estado del sensor
        {
            ValorSensor = valorSensor;
        }

        public abstract void LeerValor();
        

        public abstract void EjecutarAccion(); //metodo abstracto: obligatorio implementar en clases hijas
    }

    //CLASE HIJAS
    //--------SENSOR DE PESO--------
    public class SensorPeso : Sensor
    {
        public SensorPeso(bool valorSensor) : base(valorSensor) { } //constructor que pasa el estado al constructor base

        public override void LeerValor() //sobrescribe el método LeerValor para mostrar un mensaje específico
        {
            Console.WriteLine("Analizando peso...");
        }

        public override void EjecutarAccion() //implementa el método abstracto: evalúa el peso ingresado por consola
        {
            float peso;

            do
            {
                Console.WriteLine("Ingrese el peso actual (kg): ");
                string entrada = Console.ReadLine();                 // Lee peso como texto
                 peso = Convert.ToSingle(entrada);              // Convierte a número flotante

                if (peso >= 700)                                     // Verifica si excede el límite
                {
                    Console.Clear();
                    Console.WriteLine("Error: elevador en sobrepeso, operación detenida.");
                    Console.WriteLine("Peso ingresado: {0} kg (Límite: 700 kg)", peso);
                    //return false;
                }
                else
                {
                    Console.WriteLine("Peso permitido ({0} kg). \nEl elevador puede continuar.", peso);
                    //return = true;
                }
            } while (peso > 700);
        }
    }

    //----------SENSOR DE PRESENCIA-----
    public class SensorPresencia : Sensor
    {
        public SensorPresencia(bool valorSensor) : base(valorSensor) { } //constructor que pasa el estado al constructor base

        public override void LeerValor() //sobrescribe el metodo LeerValor con un mensaje diferente
        {
            Console.WriteLine("Detectando presencia...");
        }

        public override void EjecutarAccion() //implementa el método abstracto: evaloa si hay alguien en la puerta
        {
            string entrada;
            do
            {
                Console.WriteLine("¿Hay presencia en la puerta? (si/no): ");
                entrada = Console.ReadLine();

                if (entrada.ToLower() == "si")
                {
                    Console.Clear();
                    Console.WriteLine("Presencia detectada. \nOperación detenida. ¡Aléjese de la puerta!");
                    //return = false; 
                }
                else
                {
                    Console.WriteLine("No hay presencia. El elevador puede continuar.");
                    //return = true;
                }
            } while (entrada == "si");
        }
    }
}
