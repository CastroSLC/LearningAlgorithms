namespace LearningAlgorithms.Algoritmos.Medium {
    /*
        https://leetcode.com/problems/pairs-of-songs-with-total-durations-divisible-by-60/description/ 
        Dada una lista de canciones representadas por su duración en segundos, regresa el número de pares de canciones cuya duración total es divisible por 60.
        
        Explicación 
        Input -> time = [30, 20, 150, 100, 40]

        3 pares tienen una duración total divisible por 60:
        (time[0] = 30, time[2] = 150): duración total 180
        (time[1] = 20, time[3] = 100): duración total 120
        (time[1] = 20, time[4] = 40): duración total 60

        Output -> 3
    */

    public static class Songs {

        //Test 1: time -> [30, 20, 150, 100, 40]
        //Test 2: time -> [60, 60, 60]
        //Test 3: time -> [10, 50, 90, 30]
        public static int NumPairsDivisibleBy60(int[] time) {
            int result = 0;
            List<int> auxList = new List<int>(time);

            while(auxList.Count > 0) {
                int current = auxList[0];
                auxList.RemoveAt(0);

                foreach(int t in auxList) {
                    if((current + t) % 60 == 0) {
                        result++;
                    }
                }
            }

            Console.WriteLine("Número de canciónes divisibles por 60: " + result);
            return result;
        }

        //Test 1: time -> [30, 20, 150, 100, 40]
        //Test 2: time -> [60, 60, 60]
        //Test 3: time -> [10, 50, 90, 30]
        public static int OptimalSolution(int[] time) {
            int[] remanentes = new int[60];
            int count = 0;


            foreach(int t in time) {
                int r = t % 60;
                int complement = (60 - r) % 60;

                count += remanentes[complement];

                remanentes[r]++;
            }
            Console.WriteLine("Número de canciónes divisibles por 60: " + count);
            return count;
        }
    }
}
