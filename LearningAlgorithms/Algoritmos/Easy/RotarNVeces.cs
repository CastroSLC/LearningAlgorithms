using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAlgorithms.Algoritmos.Easy {
    /*
        Dado un arreglo de enteros y un número k, devuelve un nuevo arreglo donde los elementos han sido rotados k posiciones hacia la derecha. 
        Los elementos que sobrepasan el final del arreglo deben colocarse al inicio
    
        Ejemplo:
        Entrada: [1,2,3,4,5],
        K = 2, es el número de posiciones que debe rotar el valor
        Salida: [4,5,1,2,3]
    */
    public static class RotarNVeces {
        static int[] rotar = new int[] { 1, 2, 3, 4, 5 };
        static int k = 2;
        static int[] resultado = new int[rotar.Length];

        public static void RotarDerecha() {
            
            for(int i = 0; i < rotar.Length; i++) {
                // Calcular la nueva posición para cada elemento
                //Ejemplo, i vale 0 la primera vez
                //(0 + 2) % 5 = 2
                //Por lo tanto el 1 se mueve a la posición 2
                resultado[( i + k ) % rotar.Length] = rotar[i];
            }
            Console.WriteLine($"Posiciones a rotar: {k}");
            Console.WriteLine("Array Original: \n" + String.Join(",", rotar));
            Console.WriteLine("Array Rotado: \n" + String.Join(",", resultado));
        }

        //Basicamente es lo mismo, solo en vez de sumar, restamos los valores
        public static void RotarIzquierda() {
            
            for(int i = 0; i < rotar.Length; i++) {
                resultado[( i - k + rotar.Length ) % rotar.Length] = rotar[i];
            }
            Console.WriteLine($"Posiciones a rotar: {k}");
            Console.WriteLine("Array Original: \n" + String.Join(",", rotar));
            Console.WriteLine("Array Rotado Izquierda: \n" + String.Join(",", resultado));

        }
    }
}
