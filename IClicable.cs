using System.Numerics;

namespace NotBlons;

public interface IClicable
{
    public void IsMouseHover(Vector2 mousepos);
    public void OnClick();
}
