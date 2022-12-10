using Raylib_cs;
using System.Numerics;

namespace GreedGame
{
    static class Program
    {
        public static void Main()
        {
            var ScreenHeight = 480;
            var ScreenWidth = 800;
            var Objects = new List<GameObject>();
            var Random = new Random();
            // var RandomColor = 

            Raylib.InitWindow(ScreenWidth, ScreenHeight, "GameObject");
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                // set background color to balck
                Raylib.ClearBackground(Color.BLACK);
                
                // add a new object to the screen every iteration of the game loop
                var whichType =  Random.Next(300);

                var randomY = Random.Next(1, 3);
                var randomX = Random.Next(0, ScreenWidth);

                var position = new Vector2(randomX, 0);

                switch (whichType) {
                    case 0:
                        Console.WriteLine("Creating a rock");
                        var rock = new GameRock(Color.GRAY, 8);
                        rock.Position = position;
                        rock.Velocity = new Vector2(0, randomY);
                        Objects.Add(rock);
                        break;
                    case 1:
                        Console.WriteLine("Creating a gem");
                        var gem = new GameRock(Color.PURPLE, 5);
                        gem.Position = position;
                        gem.Velocity = new Vector2(0, randomY);
                        Objects.Add(gem);
                        break;
                    default:
                        break;
                }
                Raylib.BeginDrawing()

            }
        }
    }
}