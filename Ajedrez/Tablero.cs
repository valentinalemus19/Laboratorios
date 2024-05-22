using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ajedrez
{
    internal class Tablero
    {
        public Pieza[,] matriz = new Pieza[8, 8];
        public string[,] tablero1 = new string[8, 8];
        
        public void ImprimirTablero()
        {
            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                string cadenaFila = "   ";
                for (int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    if (matriz[fila, columna] == null)
                    {
                        cadenaFila += "   -    ";
                        tablero1[fila,columna]= "disponible";
                    }
                    else
                    {
                        cadenaFila += matriz[fila, columna].nombre + matriz[fila, columna].color + "      ";
                        tablero1[fila,columna]= matriz[fila, columna].nombre + matriz[fila, columna].color + "      ";

                    }
                }
                Console.WriteLine(cadenaFila);
            }

        }

            public char pasarnotacion(int filadama){
                switch(filadama){
                                case 0:
                                return 'a';
                                break;
                                case 1:
                                return 'b';
                                break;
                                case 2:
                                return 'c';
                                break;
                                case 3:
                                return 'd';
                                break;
                                case 4:
                                return 'e';
                                break;
                                case 5:
                                return 'f';
                                break;
                                case 6:
                                return 'g';
                                break;
                                case 7:
                                return 'h';
                                break;
                                default:
                                return 'n';
                                break;
                            }
            }
        public void ImprimirMovimientos()
        {
            // AQUÍ VUELVE A RECORRER LA MATRÍZ 
            for (int i = 0; i < tablero1.GetLength(0); i++)
            {
                for (int j = 0; j < tablero1.GetLength(1); j++)
                {
                    if (tablero1[i, j].Contains("Dama") || tablero1[i, j].Contains("dama")) // DA DIRECTAMENTE LA POSICION DE LA DAMA POR LO TANTO SE DEBE DE EVALUAR LAS POSICIONES DESDE ESTE PUNTO
                    {
                        
                        Console.WriteLine("La dama se encuentra en la fila  : " + i + ". columna: " + j);
                        int filadamaconstante =i;
                        int filadama =i+1;
                        int filadama2 =i-1;
                        int columnadama = j;
                        int columnadama1 = j+1;
                        int columnadama2 = j-1;
                        /////////// INICIO:  EVALUA MOVIMIENTOS DE LA DAMA EN VERTICAL
                        ///
                        Console.WriteLine(" ");

                        Console.WriteLine("        Posiciones horizontales");
                        Console.WriteLine("------------------------------------------");

                        while(filadama>=0 && filadama<8){
                            
                            
                            Console.WriteLine("Posicion a mover : "+pasarnotacion(columnadama)+"."+(filadama+1));
                            filadama++;
                        }
                        while(filadama2>=0 && filadama2<8){
                            Console.WriteLine("Posicion a mover : "+pasarnotacion(columnadama)+"."+(filadama2+1));
                            filadama2--;
                        } /////////// FIN:  EVALUA MOVIMIENTOS DE LA DAMA EN VERTICAL
                        Console.WriteLine(" ");
                        Console.WriteLine("        Posiciones verticales");
                        Console.WriteLine("------------------------------------------");
                        /////////// INICIO:  EVALUA MOVIMIENTOS DE LA DAMA EN HORIZONTAL
                        while(columnadama1>=0 && columnadama1<8){
                            Console.WriteLine("Posicion a mover : "+pasarnotacion(columnadama1)+"."+(filadamaconstante+1));
                            columnadama1++;
                        }
                        while(columnadama2>=0 && columnadama2<8){
                            Console.WriteLine("Posicion a mover : "+pasarnotacion(columnadama2)+"."+(filadamaconstante+1));
                            columnadama2--;
                        } /////////// FIN:  EVALUA MOVIMIENTOS DE LA DAMA EN VERTICAL

                    }
                }

            }




        }


        
    }
}
