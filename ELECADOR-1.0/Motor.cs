namespace ELECADOR_1._0
{
    public partial class Motor
    {
            public bool Encendido;
            
            public void Encender() // funcion que simula el comportamiendo del motor al encenderse
        {
                Encendido = true;
                Console.WriteLine("El motor está encendido.");
            }

            public void Apagar() // funcion que simula el comportamiendo del motor al apagarse 
        {
                Encendido = false;
                Console.WriteLine("El motor está frenando....");
            }

        }
    }
