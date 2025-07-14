namespace ELECADOR_1._0
{
    public partial class Sensor
    {
        private bool _valorSensor;

        //atributo
        public bool ValorSensor // Propiedad pública que permite acceder/modificar
        {
            get
            {
                return _valorSensor;
            }
            set
            {
                _valorSensor = value;
            }
        }

        //metodo
        public void leerValor()
        {
            Console.WriteLine("Leyendo valores del sensor...");
        }

        //constructor
        public Sensor(bool _valorSensor)
        {
            this._valorSensor = _valorSensor;
        }
    }

    public class SensorPeso : Sensor
    {
        //atributo
        private string _pesoActual;
        private float _pesoActualNum;

        public string PesoActual
        {
            get
            {
                return _pesoActual;
            }
            set
            {
                _pesoActual = value;
            }
        }

        public float PesoActualNum
        {
            get
            {
                return _pesoActualNum;
            }
            set 
            {
                _pesoActualNum = value;
            }
        }

        //constructor
        public SensorPeso (string pesoActual, bool _valorSensor) :base (_valorSensor) // Constructor que hereda el estado del sensor y recibe el peso como texto.
        {
            this.PesoActual = pesoActual;
            
        }

        //metodo
        public bool detectarPeso() //funcion para detectar el peso en el elevador
        {
            Console.WriteLine("Analizando peso...");

            string PesoActual = Console.ReadLine();
            float pesoActualNum = Convert.ToSingle(PesoActual); //conversion a flotante el peso
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("El peso del elevador es {0} kg", PesoActual); //aqui ingresas cuanto peso el que hay en el elevador

            if (pesoActualNum >= 700) //si el peso es mayor o igual, se ejecuta (no puede continuar el elevador)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Error: elevador en sobrepeso, operación detenida.");
                Console.WriteLine("Peso no permitido, {0} kg, excede limite de peso", pesoActualNum);
                float pesoExcedente = 700 - pesoActualNum;
                Console.WriteLine("¡Favor de bajar una persona o quitar {0} Kg del elevador!", pesoExcedente);
                Console.WriteLine("--------------------------------------------------------");
                return false;
            }

            else //si el peso esta dentro del limite permitido puede ejecutarse 
            {
                Console.WriteLine("Peso permitido, el elevador puede continuar");
                Console.WriteLine("Elevador funcionará correctamente.");
                return true;
            }
        }
    }

    public class SensorPresencia : Sensor
    {
        //Atributo
        private string _presencia;

        public string Presencia
        {
            get
            {
                return _presencia;
            }

            set
            {
                _presencia = value;
            }
        }

        //constructor
        public SensorPresencia(bool _valorSensor) :base (_valorSensor) 
        {
            this.Presencia = Presencia;
        }

        //metodo
        public bool detectarPresencia()
        {
            Console.WriteLine("Detectando presencia en la puerta...");
            string presencia = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------");

            if (presencia == "si")
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Error: presencia detectada, operación detenida.");
                Console.WriteLine("Presencia detectada");
                Console.WriteLine("¡Favor de aeljarse de la puerta!");
                Console.WriteLine("--------------------------------------------------------");
                return false;
            }

            else
            {
                Console.WriteLine("Presencia no detectada");
                Console.WriteLine("El elevador puede continuar");

                return true;
            }
        }
    }
}
