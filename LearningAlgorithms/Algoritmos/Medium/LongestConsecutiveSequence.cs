namespace LearningAlgorithms.Algoritmos.Medium {
    /*
        https://leetcode.com/problems/longest-consecutive-sequence/description/
        Dado un array desordenado de números enteros. Regresa el tamaño de la secuencia consecutiva más larga.
        Debes escribir un algoritmo que se ejecute en O(n) tiempo.
    
        Input -> nums = [100, 4, 200, 1, 3, 2]
        Output -> 4

        La secuencia consecutiva más larga es [1, 2, 3, 4]. Por lo tanto su longitud es 4.
    */

    public static class LongestConsecutiveSequence {

        //Test 1: nums -> [100, 4, 200, 1, 3, 2]
        //Test 2: nums -> [0, 3, 7, 2, 5, 8, 4, 6, 0, 1]
        //Test 3: nums -> [1, 2, 0, 1]
        public static int LongenstSequence(int[] nums) {
            int sequence = 1;
            
            //Ya que el algoritmo no nos dice si esta permitido o no ordenar el arreglo, lo más sencillo de inicio es hacerlo.
            Array.Sort(nums);

            //Una vez ordenados, deberemos ir recorriendo el arreglo y verificar si el número siguiente es consecutivo o no.
            //Nota: Empezamos en 1 ya que una vez ordenado el arreglo, siempre tendremos por lo menos 1 secuencía
            for(int i = 1; i < nums.Length; i++) {
                if(nums[i] == nums[i - 1])
                    continue; //Ignoramos los dúplicados

                if(nums[i] == nums[i - 1] + 1)
                    sequence++;
            }

            Console.WriteLine("La secuencia más larga es de: " + sequence);

            return sequence;
        }


        //Método sin ordenar el array
        //En este caso utilizaremos un HashMap ya que recuerda, el inicio de la sequencia puede darse si el número anterior no existe

        //Test 1: nums -> [100, 4, 200, 1, 3, 2]
        //Test 2: nums -> [0, 3, 7, 2, 5, 8, 4, 6, 0, 1]
        //Test 3: nums -> [1, 2, 0, 1]
        public static int LongestSequenceWithHashMap(int[] nums) {
            HashSet<int> data = new HashSet<int>(nums);
            int longest = 0; //longest nos ayudará a guardar la secuencia más larga encontrada

            foreach(int number in nums) {
                //Si el número anterior no existe, quiere decir que es el inicio de la secuencía, no tiene un previo
                if(!data.Contains(number - 1)) {
                    int current = number;
                    int sequence = 1; //sequence se inicializa en 1 por que ya tenemos el número actual, es decir, el inicio de la secuencia

                    //Mientras el hash contenga el número consecutivo, incrementamos nuestra sequencia
                    while(data.Contains(current + 1)) {
                        current++; //Aumentamos el número actual para que no quede en un ciclo infinito
                        sequence++;
                    }

                    longest = Math.Max(longest, sequence);
                }
            }

            Console.WriteLine("La secuencia más larga es de: " + longest);
            return longest;
        }
    }
}
