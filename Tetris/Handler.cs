using System;

namespace Tetris
{
    static class Handler
    {
        // Properties
        private static Shape[] shapesArray;

        // Constructor
        static Handler()
        {
            // Ajouter les formes dans le tableau
            shapesArray = new Shape[]
                {
                    new Shape {
                        width = 2,
                        height = 2,
                        points = new int[,]
                        {
                            { 1, 1 },
                            { 1, 1 }
                        }
                    },
                    new Shape {
                        width = 1,
                        height = 4,
                        points = new int[,]
                        {
                            { 1 },
                            { 1 },
                            { 1 },
                            { 1 }
                        }
                    },
                    new Shape {
                        width = 3,
                        height = 2,
                        points = new int[,]
                        {
                            { 0, 1, 0 },
                            { 1, 1, 1 }
                        }
                    },
                    new Shape {
                        width = 3,
                        height = 2,
                        points = new int[,]
                        {
                            { 0, 0, 1 },
                            { 1, 1, 1 }
                        }
                    },
                    new Shape {
                        width = 3,
                        height = 2,
                        points = new int[,]
                        {
                            { 1, 0, 0 },
                            { 1, 1, 1 }
                        }
                    },
                    new Shape {
                        width = 3,
                        height = 2,
                        points = new int[,]
                        {
                            { 1, 1, 0 },
                            { 0, 1, 1 }
                        }
                    },
                    new Shape {
                        width = 3,
                        height = 2,
                        points = new int[,]
                        {
                            { 0, 1, 1 },
                            { 1, 1, 0 }
                        }
                    }
                };
        }

        // Getter d'une forme ramdom 
        public static Shape getRandomShape()
        {
            var shape = shapesArray[new Random().Next(shapesArray.Length)];
            return shape;
        }
    }
}