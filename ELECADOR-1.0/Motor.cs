namespace ELECADOR_1._0
{
    public partial class Motor
    {
            public bool Encendido;
            public string Direccion;  // "arriba", "abajo", "detenido"

            public void Encender() 
            {
                Encendido = true;
                Console.WriteLine("El motor está encendido.");
            }

            public void Apagar()
            {
                Encendido = false;
                Direccion = "detenido";
                Console.WriteLine("El motor está frenando.");
            }

        }
    }
