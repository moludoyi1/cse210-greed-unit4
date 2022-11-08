using Raylib_cs;
using System.Numerics;

class GameObject {
    public Vector2 Position{get; set;} = new Vector2(0, 0);
    public Vector2 Velocity{get; set;} = new Vector2(0, 1);

    virtual public void Draw() {
        // not available at the moment
    }

    public void Move() {
        Vector2 NewPostion = this.Position;
        NewPostion.X += Velocity.X;
        NewPostion.Y += Velocity.Y;
        this.Position = NewPostion;
    }
}


class ColoredObject: GameObject {
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
        Raylib.DrawCircle((int)Position.X, (int)Position.Y, Size, Color);
    }
}

class GameGem {
    public int  {get; set;}

    public
}