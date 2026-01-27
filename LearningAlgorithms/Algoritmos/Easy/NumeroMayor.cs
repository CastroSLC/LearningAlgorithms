using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAlgorithms.Algoritmos.Easy {
    /*
        Dado un arreglo N[10,29,34,10,45,3,5] encuentra el SEGUNDO número más grande sin ordenar el arreglo.
        Output: 34
    */
    public static class NumeroMayor {
        static int[] input = new int[] { 10, 29, 34, 10, 45, 3, 5 };
        static int primero = 0, segundo = 0;

        public static void ObtenSegundoNumeroMayor() {
            foreach(int valorActual in input) {
                if(valorActual > primero) {
                    segundo = primero;
                    primero = valorActual;
                } else if(valorActual > segundo && valorActual != primero) {
                    segundo = valorActual;
                }
            }

            Console.WriteLine("El segundo número más grande es: " + segundo);
        }
    }
}
