

namespace ELECADOR_1._0
{
    //clase padre
    public partial class Indicador
    {
        // Atributo privado
        private int _estado;

        // Propiedad pública
        public int Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        // Constructor
        public Indicador(int estado)
        {
            this._estado = estado;
        }

        // Método general
        public void MostrarEstado()
        {
            Console.WriteLine( "Cambiando Numeración de piso en pantalla ");
        }
        
        //clase hija
        public class indicadorDePiso : Indicador
        {
            // Atributo privado
            private int _numeroDePiso;

            // Propiedad pública
            public int NumeroDePiso
            {
                get { return _numeroDePiso; }
                set { _numeroDePiso = value; }
            }

            // Constructor que usa base
            public indicadorDePiso(int estado, int piso) : base(estado)
            {
                this._numeroDePiso = piso;
            }

            // Método propio
            public void actualizar(int nuevoPiso, int estado)
            {
                base.MostrarEstado();
                Thread.Sleep(1000);
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("Pasamos del piso: {0}",estado);
                Thread.Sleep(1000);
                Console.WriteLine("Al piso: {0}",nuevoPiso);
                Console.WriteLine("---------------------------------------------------");
            }

        }
    }
}
