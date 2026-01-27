using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAlgorithms.Algoritmos.Advanced {
    /*
        Question 1: Array Manipulation - Neighbor Sum
        Given an array a, your task is to output an array b of the same length by applying the following transformation:

        For each i from 0 to a.length - 1 inclusive, b[i] = a[i - 1] + a[i] + a[i + 1]
        If an element in the sum a[i - 1] + a[i] + a[i + 1] does not exist, use 0 in its place
        For instance, b[0] = 0 + a[0] + a[1]

        Input: [4, 0, 1, -2, 3]
        Output: [4, 5, -1, 2, 1]
    */

    public static class NeighborSum {
        static int[] input = new int[] { 4, 0, 1, -2, 3 };
        static int[] output = new int[input.Length];
        static int a, b, c = 0;

        public static void GetNeighborSum() {
            for(int i = 0; i < input.Length; i++) {
                if(i == 0) {
                    a = 0;
                } else {
                    a = input[i - 1];
                }

                b = input[i];

                if(i == input.Length - 1) {
                    c = 0;
                } else {
                    c = input[i + 1];
                }

                output[i] = a + b + c;
                Console.WriteLine($"i: {i}, a: {a}, b: {b}, c: {c}, output[i]: {output[i]}");
            }
            Console.WriteLine(String.Join(',', output));
        }
    }
}
