using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAlgorithms.Algoritmos.Easy {
    //Proyecto para tener conocimiento sobre algoritmos con distintos problemas
    public class QuitaDuplicadosArray {
        //1-. Dado un arreglo de enteros, devuelve un nuevo arreglo sin duplicados (No LinQ, no HashSet)
        static int[] ints = new int[] { 1, 2, 2, 2, 2, 3, 3, 3, 2, 5, 2, 4, 7, 4, 5, 9, 6, 6, 8 };
        
        public static void QuitaDuplicadosConSort() {
            List<int> newArray = new List<int>();

            //Permitiendo el sort
            Array.Sort(ints);

            //El primer elemento de la lista nunca existira, por eso lo agregamos
            newArray.Add(ints[0]);

            for(int i = 1; i < ints.Length; i++) {
                if(ints[i] != ints[i - 1])
                    newArray.Add(ints[i]);
            }

            Console.WriteLine("Manual Method (Short) \n" + String.Join(",", newArray));
        }

        public static void QuitaDuplicadosNOSort() {
            //1.1-. Dado un arreglo de enteros, devuelve un nuevo arreglo sin duplicados (No HashSet, no LinQ, no Array.Sort)
            
            List<int> newArray2 = new List<int>();
            newArray2.Add(ints[0]);

            foreach(int n in ints) {
                //Hacemos un .Any para determinar si el valor existe, en caso de no ser así lo agregamos
                if(!newArray2.Any(x => x == n))
                    newArray2.Add(n);
            }

            Console.WriteLine("Manual Method (NO Short) \n" + String.Join(",", newArray2));
        }

        public static void QuitaDuplicadosConHashSet() {
            //1.2-. Dado un arreglo de enteros, devuelve un nuevo arreglo sin duplicados (HashSet permitido)
            HashSet<int> array2 = new HashSet<int>();
            foreach(int x in ints)
                array2.Add(x);

            Console.WriteLine("Method HashSet \n" + String.Join(",", array2));
        }

        public static void QuitaDuplicadosConLinQ() {
            //1.3-. Dado un arreglo de enteros, devuelve un nuevo arreglo sin duplicado (LinQ permitido)
            int[] array3 = ints.Distinct().ToArray();
            Console.WriteLine("Method LinQ \n" + String.Join(",", array3));
        }
    }
}
