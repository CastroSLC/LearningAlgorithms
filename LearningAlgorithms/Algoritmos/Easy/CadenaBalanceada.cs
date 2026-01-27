using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAlgorithms.Algoritmos.Easy {
    //Dado un string de parentesis Ejempl: "((())())", Validar si la cadena tiene parentesis balanceados
    // Entrada: "((())())" → válido
    // Entrada: "(()" → inválido
    public static class CadenaBalanceada {
        static string input = "((())(())";

        static int parentesisAbiertos = 0;
        static int parentesisCerrados = 0;

        public static void BalanceConFor() {
            //Solucion con for, contamos el número de caracteres por cada tipo de paréntesis, si son iguales, están balanceados
            for(int i = 0; i < input.Length; i++) {
                char c = input[i];

                if(c == '(') {
                    parentesisAbiertos++;
                } else if(c == ')') {
                    parentesisCerrados++;
                }
            }

            if(parentesisAbiertos == parentesisCerrados) {
                Console.WriteLine($"La cadena esta balanceada.");
            } else {
                Console.WriteLine($"La cadena NO esta balanceada.");
            }
        }

        public static void BalanceConStack() {
            //Solución con pilas 
            Stack<char> stack = new Stack<char>();

            foreach(char character in input) {
                if(character.Equals('('))
                    stack.Push(character);
                else if(character.Equals(')')) {
                    stack.Pop();
                }
            }

            if(stack.Count == 0) {
                Console.WriteLine($"La cadena esta balanceada.");
            } else {
                Console.WriteLine($"La cadena NO esta balanceada.");
            }
        }
    }
}
