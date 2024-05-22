using Ajedrez;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Proyecto2;
class Program
{

    public static void Main(string[] args)
    {

        Console.WriteLine("Bienvenido usuario");
        Console.WriteLine(""); //Bienvenida al usuario
        int numero = 0;
        Console.WriteLine("Cuantas piezas desea agregar?");
        numero = int.Parse(Console.ReadLine());
        Pieza[] piezas = new Pieza[numero]; 

        string posicionDama = "";
        Tablero tablero = new Tablero();

        string nombrepieza = "";
        string colorpieza = "";
        string colorDama = "";
        int fila = 0;
        int columna = 0;

        for (int i = 0; i < numero; i++) //Ciclo para preguntar la N cantidad de veces las piezas a utilizar
        {
            Pieza pieza1;
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("     Menu piezas a utilizar  ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("a. Alfil blanco");
            Console.WriteLine("b. peon blanco");
            Console.WriteLine("c. caballo blanco");
            Console.WriteLine("d. torre blanco");
            Console.WriteLine("e. Alfil negro");
            Console.WriteLine("f. peon negro");
            Console.WriteLine("g. caballo negro");
            Console.WriteLine("h. torre negro");
            Console.WriteLine("Ingrese la letra de la pieza que desea utilizar");


            char pieza = char.Parse(Console.ReadLine());


            switch (pieza) //Ciclo para epecificar el tipo de pieza que selecciono el usuario
            {
                case 'a':
                    nombrepieza = "Alfil ";
                    colorpieza = "Blanco";
                    break;
                case 'b':
                    nombrepieza = "Peon ";
                    colorpieza = "Blanco";
                    break;
                case 'c':
                    nombrepieza = "Caballo ";
                    colorpieza = "Blanco";
                    break;
                case 'd':
                    nombrepieza = "Torre ";
                    colorpieza = "Blanco";
                    break;
                case 'e':
                    nombrepieza = "Alfil ";
                    colorpieza = "Negro";
                    break;
                case 'f':
                    nombrepieza = "Peon ";
                    colorpieza = "Negro";
                    break;
                case 'g':
                    nombrepieza = "Caballo";
                    colorpieza = "Negro";
                    break;
                case 'h':
                    nombrepieza = "Torre ";
                    colorpieza = "Negro";
                    break;
            }

            Console.WriteLine("Ingrese la fila de la pieza: ");
             fila = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la columna de la pieza: ");
             columna = Int32.Parse(Console.ReadLine());
            tablero.matriz[fila, columna] = new Pieza(" ", nombrepieza + " " + colorpieza);


        }


        Console.WriteLine("---------------------------------------");
        Console.WriteLine("                Dama                   ");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("a. Dama blanca");
        Console.WriteLine("b. Dama negra ");
        Console.WriteLine("Ingrese la letra acorde al color que desea que sea la dama.");
        char dama = char.Parse(Console.ReadLine());

        switch (dama)
        {
            case 'a':
                colorDama = "Dama blanca";
                break;
            case 'b':
                colorDama = "Dama Negra";
                break;
        }
        Console.WriteLine("Ingrese la fila de la dama: ");
        int filaDama = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la columna de la dama");
        int columnaDama1 = Int32.Parse(Console.ReadLine());

        if (tablero.matriz[filaDama, columnaDama1] == pieza.nombre)
        {
            Console.WriteLine("Posicion valida valida");
        }
        else
        {
            Console.WriteLine("Posicion Disponible");
        }
       

        tablero.matriz[filaDama, columnaDama1] = new Pieza(" ", colorDama);
        //tablero.ImprimirMatriz
        tablero.ImprimirTablero();
        tablero.ImprimirMovimientos();

    }
}