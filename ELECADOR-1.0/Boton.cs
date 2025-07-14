namespace ELECADOR_1._0
{
    public partial class Boton
    {
        private bool _presionado; // variable para saber si el boton esta presionado o no
        public Boton (bool _presionado)
        {
            this._presionado = _presionado; // constructor que inicializa el estado del boton
        }
        public bool Presionado { get { return _presionado; } } 
            
        public void presionar() 
        {
            _presionado = true; // cambia el estado del boton a presionado
            Console.WriteLine("Boton presionado"); 
        }

        public class Botonpuerta : Boton // clase que hereda de Boton para controlar la puerta del elevador
        {
            public Botonpuerta(bool _presionado):base(_presionado) // constructor que llama al constructor de la clase Boton
            {
                
            }
            public void abrirPuerta()
            {
                base.presionar(); // llama al metodo presionar de la clase Boton
                Console.WriteLine("*Puerta esta abierta...*");
            }

            public void cerrarPuerta()
            {
                base.presionar(); // llama al metodo presionar de la clase Boton
                Console.WriteLine("*Puerta esta cerrada...*");
            }

        }

        public class Botonpiso : Boton // clase que hereda de Boton para controlar los botones de los pisos
        {

            public Botonpiso( bool _presionado) : base(_presionado) // constructor que llama al constructor de la clase Boton
            {
               
            }
            public void seleccionarPiso(int piso, int pisoact)
            {

                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("A QUE PISO QUIERES IR?");
                Console.WriteLine("...1...\n...2...\n...3...\n...4...\n...5...");
                Console.WriteLine("------------------------------------------------------");
                piso = Convert.ToInt32(Console.ReadLine());

                if (piso < 1 || piso > 5)
                {
                    Console.WriteLine("Piso no valido, por favor ingrese un piso entre 1 y 5.");
                    return;
                }

                if (piso == pisoact)
                {
                    Console.WriteLine("Ya estás en el piso ingresado \n Ingresa otro piso");
                    return;
                }
                    
                base.presionar(); // llama al metodo presionar de la clase Boton
                Console.WriteLine("Botón del piso {0} presionado", piso);


            }
        }
    }
}
