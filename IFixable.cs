namespace NotBlons;

public interface IFixable : IHurtable
{
    public void OnHeal(float antiDamage);
}
