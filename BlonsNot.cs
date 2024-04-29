using System.ComponentModel.Design;
using System.Numerics;
using System.Reflection;

namespace NotBlons;

public class BlonsNot : IDrawable, IFixable, IMovable
{
    public Vector2 Trueposition=new(100,100);
    
    Random random = new();
    
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
            Raylib.DrawCircle((int)Trueposition.X,(int)Trueposition.Y,20,Color.Red);  
        }
    }


    public Vector2 HereIAm(float deltaTime,float dir1,float dir2,bool randomspeed)
    {
        Vector2 vector2;
        if (randomspeed)
        {
            float r1 = random.Next(-200,200);
            float r2 = random.Next(-200,200);
            vector2 = new(r1,r2);
            vector2 =vector2 * deltaTime;        
        }
        else 
        {
            vector2 =new(dir1,dir2);
            vector2 =vector2 * deltaTime;
        }

        
        Trueposition = Trueposition+vector2;
        return Trueposition;
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
