using System.Numerics;

namespace NotBlons;

public class Monk : IAttack, IDrawable, IClicable
{
    public void Draw()
    {
        Raylib.DrawCircle(100,100,31.4f,Color.Brown);
    }

    public void IsMouseHover(Vector2 mousepos)
    {
        
    }

    public void OnClick()
    {
        
    }

    public void Powie(int atack)
    {
        
    }
}
