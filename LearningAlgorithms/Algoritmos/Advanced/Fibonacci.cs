namespace LearningAlgorithms.Algoritmos.Advanced {
    /*
        * Escribe un programa que imprima los 50 primeros números de la sucesión
        * de Fibonacci empezando en 0.
        * - La serie Fibonacci se compone por una sucesión de números en
        *   la que el siguiente siempre es la suma de los dos anteriores.
        *   0, 1, 1, 2, 3, 5, 8, 13...
    */
    public static class Fibonacci {
        public static void GetFibonacci() {
            long[] fibonacci = new long[50];
            long value = 0;
            long firstPreviousValue = 0;
            long secondPreviousValue = 0;

            for(int i = 0; i < 50; i++) {
                switch (i) {
                    case 0: {
                        fibonacci[0] = 0;
                        firstPreviousValue = 0;
                        secondPreviousValue = 0;
                        fibonacci[i] = firstPreviousValue + secondPreviousValue;
                        break;
                    }
                    

                    case 1: {
                        secondPreviousValue = 0;
                        firstPreviousValue = i;
                        fibonacci[i] = firstPreviousValue + secondPreviousValue;
                        break;
                    }
                    
                    
                    default: {
                        secondPreviousValue = fibonacci[i - 2];
                        firstPreviousValue = fibonacci[i - 1];
                        fibonacci[i] = firstPreviousValue + secondPreviousValue;
                        break;
                    }
                }
            }

            Console.WriteLine(String.Join(',', fibonacci));

        }
    }
}
