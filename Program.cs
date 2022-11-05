using Raylib_cs;
using System.Numerics;

namespace GreedGame
{
    static class Program
    {
        public static void Main()
        {
            // var ScreenHeight = 480;
            // var ScreenWidth = 800;
            Raylib.InitWindow(800, 480, "Score: ");

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                Raylib.DrawText("Score: ", 12, 12, 20, Color.WHITE);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }

        public int Score()
        {
            
        }
    }
}