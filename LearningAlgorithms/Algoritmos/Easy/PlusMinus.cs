namespace LearningAlgorithms.Algoritmos.Easy {
    /*
        Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. 
        Print the decimal value of each fraction on a new line with 6 places after the decimal.

        Note: This challenge introduces precision problems. 
        The test cases are scaled to six decimal places, though answers with absolute error of up to 10^4 are acceptable.

        Example:
        array = [1, 1, 0, -1, -1]
        There are N=5 elements: two positive, two negative and one zero. Their ratios are 2/5 = 0.400000, 2/5 = 0.400000 and 1/5 = 0.200000. Results are printed as:

        Output:
        0.400000
        0.400000
        0.200000
    */
    public static class PlusMinus {
        static void GetPlusMinus(List<int> arr) {
            //Debemos determinar el número de positivos, negativos y zeros que hay en el array
            //Para eso recorremos el array primero
            int positivos = 0, negativos = 0, zero = 0, count = arr.Count;

            for(int i = 0; i < count; i++) {
                if(arr[i] > 0) {
                    positivos++;
                } else if(arr[i] < 0) {
                    negativos++;
                } else {
                    zero++;
                }
            }

            //Despues simplemente debemos calcular los ratios y mostrarlos con 6 decimales
            Console.WriteLine(( (double) positivos / count ).ToString("F6"));
            Console.WriteLine(( (double) negativos / count ).ToString("F6"));
            Console.WriteLine(( (double) zero / count ).ToString("F6"));
        }
    }
}
