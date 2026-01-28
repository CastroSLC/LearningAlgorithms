namespace LearningAlgorithms.Algoritmos.Advanced {
    /* 
        Question 2: String Pattern Matching - Anagram Groups
        Given an array of strings strs, group the anagrams together. You can return the answer in any order.

        An anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

        Example: For strs = ["eat", "tea", "tan", "ate", "nat", "bat"]:

        The output should be [["eat", "tea", "ate"], ["tan", "nat"], ["bat"]].
    */
    public static class Anagram {
        static string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
        static Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();

        public static void GetAnagram() {
            foreach(string word in strs) {
                // Ordenamos las letras
                char[] chars = word.ToCharArray();
                Array.Sort(chars);
                string key = new string(chars);

                // Agrupamos por clave
                if(!groups.ContainsKey(key))
                    groups[key] = new List<string>();

                groups[key].Add(word);
            }

            // Convertimos a lista de listas
            List<List<string>> result = new List<List<string>>(groups.Values);

            // Mostrar resultado
            foreach(var group in result) {
                Console.WriteLine("[" + string.Join(", ", group) + "]");
            }
        }
    }
}
