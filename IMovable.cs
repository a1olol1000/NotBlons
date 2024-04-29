using System.Numerics;

namespace NotBlons;

public interface IMovable
{
    public Vector2 HereIAm(float deltaTime,float dir1,float dir2,bool randomspeed);
}
