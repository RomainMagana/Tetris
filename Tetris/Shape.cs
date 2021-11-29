using System;

namespace Tetris
{
    public class Shape
    {
        public int width;
        public int height;
        public int[,] points;

        private int[,] tempPoints;

        public void turn()
        {
            // Tempon de points
            tempPoints = points;

            points = new int[width, height];

            for (int i = 0; i < width; i++) {
                for (int j = 0; j < height; j++) {
                    points[i, j] = tempPoints[height - 1 - j, i];
                }
            }

            var temp = width;
            width = height;
            height = temp;
        }

        // Lorsque la rotate n'est pas possible
        // car touche une autre forme
        public void rollback()
        {
            points = tempPoints;

            var temp = width;
            width = height;
            height = temp;
        }
    }
}