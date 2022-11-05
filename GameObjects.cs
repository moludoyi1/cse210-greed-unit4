using Raylib_cs;
using System.Numerics;

class GameObject {
    public Vector2 Position{get; set;} = new Vector2(0, 0);
    public Vector2 Velocity{get; set;} = new Vector2(0, 0);
}

class ColoredObject {
    public Color Color{get; set;}

    public ColoredObject(Color color) {
        Color = color;
    }
}

class GameRock {
    public int Size {get; set;}
    
    public GameRock(Color color, int size): base(color) {
        Size = size;
    }

    override public void Draw() {
        Raylib.Draw
    }
}

class GameGem {
    public int  {get; set;}

    public
}