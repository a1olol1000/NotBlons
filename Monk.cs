using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace NotBlons;

public class Monk : IAttack, IDrawable, IClicable
{
    public float counter =0;
    public void Draw()
    {
        Raylib.DrawCircle(100,100,31.4f,Color.Brown);
    }

    public void IsMouseHover(Vector2 mousepos)
    {
        
    }

    public void OnClick()
    {
        counter ++;
    }

    public void Powie(int atack)
    {
        
    }
}
