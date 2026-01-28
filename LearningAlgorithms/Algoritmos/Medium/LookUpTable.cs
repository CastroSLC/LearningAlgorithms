namespace LearningAlgorithms.Algoritmos.Medium {
    /*
        Dado un array de números (positivos y negativos). Tu tarea es encontrar el número de indices pares(i, j) tal que
        i < j y la suma de los elementos en esas posiciones numero[i] + numero[j] sea igual alguna potencia de 2
        Nota: Los números 2^0 = 1, 2^1 = 2, 2^2 = 4, 2^3 = 8, ... son todas las potencias de 2 
        
        Ejemplo:
        Para los números [1, 3, 5, 7, 9], la salida debería ser Solution(numbers) = 4.
        Explicación: Los pares que suman potencias de 2 son (1, 3), (1, 5), (3, 5) y (5, 7).
        - (1, 3) = 4 = 2^2
        - (1, 5) = 6 = 2^3
        - (3, 5) = 8 = 2^4
        - (5, 7) = 12 = 2^5
        La salida debería ser "4", ya que hay cuatro pares que cumplen la condición.
        Recuerda que i < j, por lo que (3, 1) no cuenta. 
        - (1, 1) = no cuenta porque i no es menor que j.
    */
    
    public static class LookUpTable {

        //Test 1 : numbers = [1, 3, 5, 7, 9] => Output: 4
        //Test 2 : numbers = [1, -1, 2, 3] => Output: 3
        //Test 3 : numbers = [0, 2, 4, 6, 8, 10] => Output: 5
        public static int Solution(int[] numbers) {
            int count = 0;

            //Debemos crear dos For, ya que tenemos que ir pasando número por número y sumándolos
            for(int i = 0; i < numbers.Length; i++) {
                for(int j = 0; j < numbers.Length; j++) {
                    if(i < j) {
                        int sum = i + j;

                        //La solución facil es utilizar Math.Log2, para verificar si el logaritmo en base 2 de la suma es un número entero, entonces es potencia de 2
                        //Recordemos que si es una potencia, cuando se divide entre 2, el resultado siempre es un número entero, en este caso el residuo siempre será 0
                        //Por eso lo dividos en 1, si el residuo es 0, entonces es potencia de 2
                        //if(Math.Log2(sum) % 1 == 0) {
                        //    count++;
                        //}

                        if(esPotenciaDeDos(sum)) count++;
                    }
                }
            }

            Console.WriteLine("Total pairs that sum to power of 2: " + count);
            return count;
        }

        //Otra solución es crear una función que verifique si un número es potencia de 2
        private static bool esPotenciaDeDos(int numero) {
            if(numero < 1) return false;
            while(numero > 1) {
                if(numero % 2 != 0) {
                    return false;
                }
                numero /= 2;
            }
            return true;
        }
    }
}
