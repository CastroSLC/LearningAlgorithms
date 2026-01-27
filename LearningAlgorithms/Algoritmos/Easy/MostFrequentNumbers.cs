namespace LearningAlgorithms.Algoritmos.Easy {
    /*
        Question 7: Heap Problem - K Most Frequent Elements
        Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.

        Example: For nums = [1, 1, 1, 2, 2, 3] and k = 2:

        The output should be [1, 2].

        Explanation:

        Element 1 appears 3 times
        Element 2 appears 2 times
        Element 3 appears 1 time
        The 2 most frequent are 1 and 2
        For nums = [1] and k = 1:

        The output should be [1].
     */
    public static class MostFrequentNumbers {
        static int[] nums = [1, 1, 1, 2, 2, 3];
        static int k = 2;

        public static List<int> GetMostFrequentNumber(int[] elements, int frequencyExpected) {
            List<int> mostFrequentValues = new List<int>();
            Dictionary<string, int> valor = new Dictionary<string, int>();

            for(int i = 0; i < elements.Length; i++) {
                int number = elements[i];

                //si el valor todavía no existe, agregalo
                if(!valor.ContainsKey(number.ToString())) {
                    valor.Add(number.ToString(), 1);
                } else {
                    //Quiere decir que ya existe
                    valor[number.ToString()] += 1;
                }
            }

            //Aqui ya por cada elemento en diccionario, solo regresamos los elementos que cumplan con la frecuencia esperada
            foreach(var item in valor) {
                if(item.Value >= frequencyExpected) {
                    mostFrequentValues.Add(int.Parse(item.Key));
                }
            }

            return mostFrequentValues;
        }
    }

    //var result = GetMostFrecuentElements(nums, k);
    //Console.WriteLine(String.Join(',', result));
}
