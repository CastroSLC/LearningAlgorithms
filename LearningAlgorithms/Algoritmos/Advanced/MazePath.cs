using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAlgorithms.Algoritmos.Advanced {
    /*
        Question 4: Graph Traversal - Shortest Path in Maze
        You are given an m x n binary maze grid where:

        0 represents an empty cell
        1 represents a wall
        You can move up, down, left, or right from and to an empty cell. 
        Return the length of the shortest path from the top-left corner (0, 0) to the bottom-right corner (m-1, n-1). 
        If there is no such path, return -1.

        Example: 
        [
        [0, 0, 1], 
        [1, 0, 0], 
        [1, 1, 0]
        ]
        
        The output should be 5. 
    */
    public static class MazePath {
        static int[,] grid = {
            {0, 0, 1},
            {1, 0, 0},
            {1, 1, 0}
        };

        

        public static int ShortestPath(int[,] grid) {
            int filas = grid.GetLength(0);
            int columnas = grid.GetLength(1);

            //Validaciones Iniciales
            if(filas == 0 || columnas == 0)
                return -1; //No hay camino

            if(grid[0, 0] == 1)
                return -1; //El inicio es un muro

            if(grid[filas - 1, columnas - 1] == 1)
                return -1; //Es un muro

            Queue<(int fil, int col, int dist)> queue = new Queue<(int, int, int)>();
            queue.Enqueue((0, 0, 1)); //Empezamos en (0,0) y la distancia 1

            HashSet<(int, int)> visitado = new HashSet<(int, int)>();
            visitado.Add((0, 0)); //Agregamos la primer coordenada que será 0,0 siempre

            //Direcciones posibles derecha, abajo, izquierda, arriba
            int[,] direcciones = { { 0, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 } };

            while(queue.Count > 0) {
                var (fila, columna, distancia) = queue.Dequeue();

                //¿Llegamos al final?
                if(fila == filas - 1 && columna == columnas - 1)
                    return distancia;

                //Explorar los vecinos
                for(int i = 0; i < 4; i++) {
                    int nuevaFila = fila + direcciones[i, 0];
                    int nuevaColumna = columna + direcciones[i, 1];

                    //Validamos los limites y que sea una celda vacia
                    if(nuevaFila >= 0 && nuevaFila < filas
                        && nuevaColumna >= 0 && nuevaColumna < columnas
                        && grid[nuevaFila, nuevaColumna] == 0
                        && !visitado.Contains((nuevaFila, nuevaColumna))) {

                        visitado.Add((nuevaFila, nuevaColumna)); //Agregamos la coordena ya que no la hemos visitado
                        queue.Enqueue((nuevaFila, nuevaColumna, distancia + 1)); //Agregamos una distancia ya que hemos recorrido un paso
                    }
                }
            }

            return -1; //No hay camino
        }
    }
}
