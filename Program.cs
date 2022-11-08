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

            Raylib.InitWindow(ScreenWidth, ScreenHeight, "GameObject");
            Raylib.SetTargetFPS(80);

            while (!Raylib.WindowShouldClose()) {
                var whichType =  Random.Next(3);

                var randomY = Random.Next(-2, 2);
                var randomX = Random.Next(-2, 2);

                var position = new Vector2(ScreenWidth, ScreenHeight); //####
                
            }
            // Raylib.InitWindow(800, 480, "Score: ");

            // while (!Raylib.WindowShouldClose())
            // {
            //     Raylib.BeginDrawing();
            //     Raylib.ClearBackground(Color.BLACK);

            //     Raylib.DrawText("Score: ", 12, 12, 20, Color.WHITE);

            //     Raylib.EndDrawing();
            // }

            // Raylib.CloseWindow();
        }

        // public int Score()
        // {
            
        // }
    }
}