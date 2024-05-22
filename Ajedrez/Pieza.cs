using System.Reflection.Metadata.Ecma335;

namespace Ajedrez
{
    internal class Pieza
    {
        public string nombre = "";
        public string color = "";
        public string Dama = "";
        public int fila = 0;
        public int columna = 0;
        public bool Movimiento = false;

        public Pieza(string nombre, string color)
        {
            this.nombre = nombre;
            this.color = color;
        }
        public Pieza(string dama)
        {
            this.Dama = dama;
        }



       
    }
}
