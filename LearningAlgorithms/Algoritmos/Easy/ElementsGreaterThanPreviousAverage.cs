namespace LearningAlgorithms.Algoritmos.Easy {
    /*
        Given an array of positive integers, return the number of elements that are strictly greater than the average of all previous elements. 
        Skip the first element.

        Input: responseTimes = [100,200,150,300]
        Output: 2

        Explanation:
        - The first element is skipped.
        - The average of elements before index 1 is 100. Since 200 > 100, we count it.
        - The average of elements before index 2 is 150 (300/2). Since 150 < 300, we do not count it.
        - The average of elements before index 3 is 150 (450/3). Since 300 > 150, we count it.
    */
    public static class ElementsGreaterThanPreviousAverage {
        //List<int> responseTimes = new List<int>() { 100, 200, 150, 300 };

        static int countResponseTimeRegressions(List<int> responseTimes) {
            //Edge case
            if(responseTimes == null)
                return 0;

            List<int> previousDays = new List<int>();
            int totalnumbers = 0;
            for(int i = 0; i < responseTimes.Count; i++) {
                if(i == 0) {
                    previousDays.Add(responseTimes[i]); //Aunque nos saltemos el día 1, debemos agregarlo a la lista de días previos
                    continue;
                }

                //Hacemos una simple comparación entre el tiempo de respuesta del día actual y el promedio de los días previos
                if(responseTimes[i] > (int) previousDays.Average()) {
                    totalnumbers++;
                }

                previousDays.Add(responseTimes[i]);
            }

            return totalnumbers;
        }
    }
}
