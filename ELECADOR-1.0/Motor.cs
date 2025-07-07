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

            public void MoverArriba()
            {
                if (Encendido)
                {
                    Direccion = "arriba";
                    Console.WriteLine("El motor mueve el elevador hacia arriba.");
                }
                else
                {
                    Console.WriteLine("No se puede mover: el motor está apagado.");
                }
            }

            public void MoverAbajo()
            {
                if (Encendido)
                {
                    Direccion = "abajo";
                    Console.WriteLine("El motor mueve el elevador hacia abajo.");
                }
                else
                {
                    Console.WriteLine("No se puede mover: el motor está apagado..");
                }
            }
        }
    }
