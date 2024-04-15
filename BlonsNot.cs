using System.ComponentModel.Design;
using System.Numerics;
using System.Reflection;

namespace NotBlons;

public class BlonsNot : IDrawable, IFixable, IMovable
{
    public Vector2 positionc;
    public bool isAlive = true;
    private float _hp = 20f;
    private float _maxHp = 20f;
    public float health
    {
        get {return _hp;}
        set{_hp=Math.Clamp(value,0,_maxHp);}
    }    
    public void Draw()
    {
        if (isAlive)
        {
            Raylib.DrawCircle((int)positionc.X,(int)positionc.Y,20,Color.Red);  
        }
    }


    public Vector2 HereIAm(Vector2 position)
    {
        positionc = positionc+position;
        return positionc;
    }

    public void OnHeal(float antiDamage)
    {
        if (isAlive)
        {
            health = health+antiDamage; 
        }

        
    }

    public void OnOuch(float damage)
    {
        health = health-damage;
        if (health < 0.01f)
        {
            isAlive = false;
        }
    }

}
