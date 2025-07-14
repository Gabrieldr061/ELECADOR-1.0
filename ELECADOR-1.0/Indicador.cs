
namespace ProyectoElevador
{
    //clase padre
    public class Indicador
    {
        // Atributo privado
        private string _estado;

        // Propiedad pública
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        // Constructor
        public Indicador(string estado)
        {
            this._estado = estado;
        }

        // Método general
        public void MostrarEstado()
        {
            
        }

        //clase hija
        public class IndicadorDePiso : Indicador
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
            public IndicadorDePiso(string estado, int piso) : base(estado)
            {
                this._numeroDePiso = piso;
            }

            // Método propio
            public void Actualizar(int nuevoPiso)
            {
                NumeroDePiso = nuevoPiso;
                Console.WriteLine("Piso actualizado a: " + nuevoPiso);
            }

        }
    }
}
