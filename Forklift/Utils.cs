using System;
using System.Collections.Generic;
using System.Text;

namespace Forklift
{
    public static class Utils
    {
        public static Quadrant[,] GenerateLabyrinth()
        {
            var labyrinth = new Quadrant[10, 10]
            {
                // 0
                {
                    new Quadrant
                    {
                        NorthWall = true,
                        SouthWall = false,
                        EastWall = false,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        SouthWall = true,
                        EastWall = false,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        SouthWall = true,
                        EastWall = false,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        SouthWall = true,
                        EastWall = false,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        SouthWall = false,
                        EastWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        SouthWall = false,
                        EastWall = false,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        SouthWall = true,
                        EastWall = false,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        SouthWall = true,
                        EastWall = false,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        SouthWall = false,
                        EastWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = false,
                        WeastWall = true
                    }
                },
                // 1
                {
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = true,
                        SouthWall = false,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = true,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = true,
                        SouthWall = false,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = false,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = true,
                        SouthWall = false,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = true,
                        SouthWall = true,
                        WeastWall = false
                    }
                },
                // 2
                {
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = false,
                        SouthWall = false,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = true,
                        SouthWall = false,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = true,
                        SouthWall = true,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = false,
                        SouthWall = false,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = true,
                        SouthWall = false,
                        WeastWall = false
                    }
                },
                // 3
                {
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = true,
                        SouthWall = false,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = true,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = true,
                        SouthWall = false,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = true,
                        SouthWall = false,
                        WeastWall = true
                    }
                },
                // 4
                {
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = false,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = true,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = false,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = true,
                        SouthWall = false,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = false,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = true,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = true
                    }
                },
                // 5
                {
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = true,
                        SouthWall = false,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = false,
                        SouthWall = false,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = true,
                        SouthWall = false,
                        WeastWall = false
                    }
                },
                // 6
                {
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = false,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = true,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = true,
                        SouthWall = false,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = false,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = true,
                        SouthWall = false,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = false,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = true,
                        SouthWall = true,
                        WeastWall = false
                    }
                },
                // 7
                {
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = false,
                        SouthWall = false,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = false,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = false,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = true,
                        SouthWall = false,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = true,
                        SouthWall = false,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = true,
                        SouthWall = false,
                        WeastWall = false
                    }
                },
                // 8
                {
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = true,
                        SouthWall = false,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = true,
                        SouthWall = false,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = true,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = true,
                        SouthWall = false,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = true,
                        SouthWall = false,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = true,
                        SouthWall = false,
                        WeastWall = false
                    }
                },
                // 9
                {
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = true,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = true,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = true
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = true,
                        EastWall = false,
                        SouthWall = true,
                        WeastWall = false
                    },
                    new Quadrant
                    {
                        NorthWall = false,
                        EastWall = true,
                        SouthWall = true,
                        WeastWall = false
                    }
                }
            };

            return labyrinth;
        }

        public static void printLabyrinth(Quadrant[,] labyrinth)
        {

            for(int i = 0; i < labyrinth.GetLength(0); i++)
            {
                for(int j = 0; j < labyrinth.GetLength(1); j++)
                {
                    if (labyrinth[i, j].NorthWall) Console.Write("__");
                    else Console.Write("  ");
                }
                Console.WriteLine();
                for (int j = 0; j < labyrinth.GetLength(1); j++)
                {
                    if (labyrinth[i, j].WeastWall) Console.Write("| ");
                    else Console.Write("  ");
                    //if (labyrinth[i, j].EastWall) Console.Write("*|");
                    //else Console.Write("*");
                }
                Console.WriteLine();
                for (int j = 0; j < labyrinth.GetLength(1); j++)
                {
                    if (labyrinth[i, j].SouthWall) Console.Write("──");
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }

        }
    }
}
