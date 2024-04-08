using System.ComponentModel.Design;
using System.Numerics;
using System.Reflection;

namespace NotBlons;

public class BlonsNot : IDrawable, IHurtable, IMovable
{
    public Vector2 positionc;
    public bool isAlive = true;
    private float _hp;
    private float _maxHp;
    public float health
    {
        get {return _hp;}
        set{Math.Clamp(_hp,0,_maxHp);}
    }    
    public void Draw()
    {
        Raylib.DrawCircle((int)positionc.X,(int)positionc.Y,20,Color.Red);
    }


    public Vector2 HereIAm(Vector2 position)
    {
        positionc = positionc+position;
        return positionc;
    }

    public void OnOuch(float damage)
    {
        health = health-damage;
        if (health == 0)
        {
            isAlive = false;
        }
    }

}
