using Raylib_cs;
using System.Numerics;

class GameRock: MovementVertical{
    // DRAW THE ROCKS
    override public void Draw() {
        Random rnd = new Random();
        int RandInt = rnd.Next(20,780);

        Raylib.DrawText("o", (int)Position.X, (int)Position.Y, 15, Color.BLUE);
    }
}


class GameGem: MovementVertical{
    // DRAW THE GEMS
    override public void Draw() {
        Random rnd = new Random();
        int RandInt = rnd.Next(20,780);

        Raylib.DrawText("*", (int)Position.X , (int)Position.Y, 15, Color.RED);
    }
}