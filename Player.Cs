using Raylib_cs;
using System.Numerics;

class Player: MovementHorizontal{
    override public void Draw(){
    var PlayerRectangle = new Rectangle(410, 400, 20, 20);
    Raylib.DrawRectangle((int)Position.X, (int)Position.Y, 20,20, Color.GREEN);
    }
}
abstract class MovementHorizontal{
    public Vector2 Position { get; set; } = new Vector2(0, 0);
    public Vector2 Velocity { get; set; } = new Vector2(0, 0);

    virtual public void Draw(){
    }
    public void MovePlayer()
    {
        Vector2 NewPosition = Position;
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
                    NewPosition.X += 2;
                    Position = NewPosition;
                }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
                    NewPosition.X -= 2;
                    Position = NewPosition;
                }
        else{
            Position = NewPosition;
        }
    }
}

abstract class MovementVertical{
    public Vector2 Position {get; set; } = new Vector2(0, 0);
    public Vector2 Velocity {get; set; } = new Vector2(0, 0);
    virtual public void Draw() {
    }
    public void MoveVertical(){
        Vector2 NewPosition = Position;
        NewPosition.X += Velocity.X;
        NewPosition.Y += Velocity.Y;
        Position = NewPosition;
    }
   
}
