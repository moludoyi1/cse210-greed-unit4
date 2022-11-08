﻿using Raylib_cs;
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
            Raylib.SetTargetFPS(80);

            while (!Raylib.WindowShouldClose())
            {
                // set background color to balck
                Raylib.ClearBackground(Color.BLACK);
                
                // add a new object to the screen every iteration of the game loop
                var whichType =  Random.Next(3);

                var randomY = Random.Next(-2, 2);
                var randomX = Random.Next(-2, 2);

                var position = new Vector2(ScreenWidth/2, 0);

                switch (whichType) {
                    case 0:
                        Console.WriteLine("Creating a rock");
                        var rock = new GameRock(Color.GRAY, 8);
                        rock.Position = position;
                        rock.Velocity = new Vector2(randomX, randomY);
                        Objects.Add(rock);
                        break;
                    case 1:
                        Console.WriteLine("Creating a gem");
                        var gem = new GameRock(Color.PURPLE, 5);
                        gem.Position = position;
                        gem.Velocity = new Vector2(randomX, randomY);
                        Objects.Add(gem);
                        break;
                    default:
                        break;
                }
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