using System.Text.RegularExpressions;

namespace LearningAlgorithms.Algoritmos.Medium {
    /*
        Dadas dos cadenas de texto, "pattern" y "source". El primer string contiene solo simbolos 0 y 1, el segundo string contiene la "fuente" de texto donde se buscará el patrón.
        Tu tarea es calcular el número de substrings de la "fuente(source)" que haga match con el "pattern".

        Constraints:
        -El "pattern" y el substring son iguales en tamaño.
        –Donde haya un 0 en el patron, debe haber una vocal en el substring.
        –Donde haya un 1 en el patron, debe haber una consonante en el substring.

        Las vocales son 'A', 'E', 'I', 'O', 'U' (mayúsculas y minúsculas).
        Las consonantes son todas las demás letras del alfabeto inglés (minúsculas).

        Ejemplo:
        Para el patron "010" y la fuente "amazing", la salida debería ser solution(pattern, source) = 2.
        – “010” hace match con la fuente[0..2] = "ama". El patron especifica “vocal, consonante, vocal”. “ama” hace match con este patrón: 0 hace match con a, 1 hace match con m, y 0 hace match con a. 
        – “010” no hace match con source[1..3] = "maz" 
        – “010” hace match con source[2..4] = "azi" 
        – “010” no hace match con source[3..5] = "zin" 
        – “010” no hace match con source[4..6] = "ing"

        La salida deberá ser "2", ya que hay dos substrings en la fuente que hacen match con el patrón.
    */


    public static class StringPatterMatch {
        // Complejidad: O(n*m) donde n es el tamaño de la fuente y m es el tamaño del patrón
        // Test 1: pattern: "010", source "amazing" => Output: 2
        // Test 2: pattern: "100", source "codesignal" => Output: 0
        public static int GetMatches(string pattern, string source) {
            int matchCount = 0;
            
            //Se podría hacer con ReGex
            //Reemplazamos las vocales con 0 y las consonantes con 1
            string newSource = Regex.Replace(source.ToLower(), "[aeiou]", "0");
            newSource = Regex.Replace(newSource, "[bcdfghjklmnpqrstvwxyz]", "1");

            //Hacemos el for para tomar el substring
            for(int i = 0; i <= newSource.Length - pattern.Length; i++) {
                string substring = newSource.Substring(i, pattern.Length);
                if(substring.Equals(pattern)) {
                    matchCount++;
                }
            }
            
            Console.WriteLine("Total matches: " + matchCount);
            return matchCount;
        }
    }
}
