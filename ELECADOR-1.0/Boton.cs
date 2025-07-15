namespace ELECADOR_1._0
{
        public partial class Boton
        {
            private bool _presionado; // variable para saber si el boton esta presionado o no
            public Boton(bool _presionado)
            {
                this._presionado = _presionado; // constructor que inicializa el estado del boton
            }
            public bool Presionado { get { return _presionado; } }

            public void presionar()
            {
                _presionado = true; // cambia el estado del boton a presionado
                Console.WriteLine("*Boton presionado...*");
            }
        }
        public class Botonpuerta : Boton // clase que hereda de Boton para controlar la puerta del elevador
        {
            public Botonpuerta(bool _presionado) : base(_presionado) // constructor que llama al constructor de la clase Boton
            {

            }
            public void abrirPuerta()
            {
                base.presionar(); // llama al metodo presionar de la clase Boton
                Thread.Sleep(1000);
                Console.WriteLine("Puerta esta abierta...");
            }

            public void cerrarPuerta()
            {
                base.presionar(); // llama al metodo presionar de la clase Boton
                Thread.Sleep(1000);
                Console.WriteLine("Puerta esta cerrada...");
            }

        }

        public class Botonpiso : Boton // clase que hereda de Boton para controlar los botones de los pisos
        {

            public Botonpiso(bool _presionado) : base(_presionado) // constructor que llama al constructor de la clase Boton
            {

            }
            public void seleccionarPiso()
            {

                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("A QUE PISO QUIERES IR?");
                Console.WriteLine("...1...\n...2...\n...3...\n...4...\n...5...");
                Console.WriteLine("------------------------------------------------------");
                
            }

        }
    
}