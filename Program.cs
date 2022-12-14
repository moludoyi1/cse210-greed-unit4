using Raylib_cs;
using System.Numerics;

class Main {
    static class Program
    {
        public static void Main()
        {
            // Accessing variables through the constant class
            var ScreenHeight = 480;
            var ScreenWidth = 800;
            var Rocks = new List<GameRock>();
            var Gems = new List<GameGem>();
            var Random = new Random();

            Raylib.InitWindow(ScreenWidth, ScreenHeight, "Greed");
            Raylib.SetTargetFPS(20);
            int score = 0;
            var PlayerPosition = new Vector2 (400,450);

            while (!Raylib.WindowShouldClose())
            {
                // INTRO TEXT 
                // Raylib.DrawText("Move the red square to the blue square with the arrow keys!", 12, 12, 20, Color.BLACK);
                Raylib.DrawText($"Score: {score}",12,12,15,Color.BLACK);

                var RockOrGem = Random.Next(2);
                int PositionX = Random.Next(0, ScreenWidth);
                var position = new Vector2 (PositionX , 0);

                switch (RockOrGem){
                    // If case is 0 it'll create a Rock
                    case 0:
                     var Rock = new GameRock();
                     Rock.Position = position;
                     Rock.Velocity = new Vector2(0,8);
                     Rocks.Add(Rock);
                     break;
                    //  IF case 1 create a GEM
                    case 1:
                        var Gem = new GameGem();
                        Gem.Position = position;
                        Gem.Velocity = new Vector2(0,8);
                        Gems.Add(Gem);
                        break;
                    default:
                        break;
                }

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);



                // Draw all of the objects in their current location
                foreach (var obj in Rocks) {
                    obj.Draw();
                }
                foreach (var obj in Gems) {
                    obj.Draw();
                }
                // Call the player class
                var Player= new Player();
                // Assign a position and a velocity to the player
                Player.Position = PlayerPosition;
                Player.Velocity = new Vector2(2, 0); 
                Player playerObj = new Player();
        // The player will be redrawn in a new position when the keyboard is pressed
                Player.Draw();
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
                    PlayerPosition.X +=6;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
                    PlayerPosition.X -=6;
                }
                Raylib.EndDrawing();

                // Move all of the objects to their next location
                foreach (var obj in Rocks) {
                    obj.MoveVertical();
                }
                foreach (var obj in Gems) {
                    obj.MoveVertical();
                }
            // Define the hitbox for the player using a rectangle
                var TheRectangle = new Rectangle(PlayerPosition.X,PlayerPosition.Y, 20, 20);
            // Go through the Rocks and Gems list and check if they're inside the hitbox
                foreach (var obj in Rocks.ToList()) {
                    if (Raylib.CheckCollisionPointRec(obj.Position, TheRectangle)) {
                        score -=1;
                    //Remove object from list if collision occurs(Doesn't work when running through the foreach loop)
                    Rocks.Remove(obj);
                    }
                }

                foreach (var obj in Gems.ToList()) {
                    if (Raylib.CheckCollisionPointRec(obj.Position, TheRectangle)) {
                        score +=1;
                    //Remove object from list if collision occurs(Doesn't work when running through the foreach loop)
                    Gems.Remove(obj);
                    }
                }

            }

            Raylib.CloseWindow();
        }
    }
}
