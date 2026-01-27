namespace LearningAlgorithms.Algoritmos.Advanced {
    /*
        Question 8: Matrix Problem - Region Sum Query (Prefix Sum)
        Given a 2D matrix, handle multiple queries of the following type:

        Calculate the sum of the elements of matrix inside the rectangle defined by its upper left corner (row1, col1) and lower right corner (row2, col2).
        Implement the NumMatrix class:

        NumMatrix(int[][] matrix) initializes the object with the integer matrix.
        int sumRegion(int row1, int col1, int row2, int col2) returns the sum of the elements of matrix inside the rectangle.
        Example:For matrix = [
            [3, 0, 1, 4, 2], 
            [5, 6, 3, 2, 1], 
            [1, 2, 0, 1, 5], 
            [4, 1, 0, 1, 7], 
            [1, 0, 3, 0, 5]
        ]

        sumRegion(2, 1, 4, 3) should return 8 (sum of the blue rectangle)
        sumRegion(1, 1, 2, 2) should return 11 (sum of the red rectangle)
    */

    public static class SumSubRegion {
        static int[,] matrix = {
            {3, 0, 1, 4, 2 },
            {5, 6, 3, 2, 1 },
            {1, 2, 0, 1, 5 },
            {4, 1, 0, 1, 7 },
            {1, 0, 3, 0, 5 }
        };

        static int SumRegion(int[,] matriz, int x, int y, int z, int w) {
            int total = 0;
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            //Validamos los limites
            if(x < 0 || y < 0 || z < 0 || w < 0 || x >= filas || y >= columnas || z >= filas || w >= columnas) {
                throw new ArgumentOutOfRangeException("Coordenadas fuera de los limites.");
            }

            #region Nueva Matriz
            int nuevasFilas = z - x + 1;
            int nuevasColumnas = w - y + 1;
            int[,] nuevaMatriz = new int[nuevasFilas, nuevasColumnas];

            for(int i = 0; i < nuevasFilas; i++) {
                for(int j = 0; j < nuevasColumnas; j++) {
                    nuevaMatriz[i, j] = matriz[x + i, y + j];
                }
            }
            #endregion

            int matrizNuevasFilas = nuevaMatriz.GetLength(0);
            int matrizNuevasColumnas = nuevaMatriz.GetLength(1);

            for(int i = 0; i < matrizNuevasFilas; i++) {
                for(int j = 0; j < matrizNuevasColumnas; j++) {
                    total += nuevaMatriz[i, j];
                }
            }

            return total;
        }
    }
}
