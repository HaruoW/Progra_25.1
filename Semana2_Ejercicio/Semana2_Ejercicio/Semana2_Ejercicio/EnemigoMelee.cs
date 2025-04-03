public class EnemigoMelee : Enemigo
{
    public EnemigoMelee(int vida, int daño) : base(vida, daño) { }

    public override int ObtenerDaño()
    {
        return daño; 
    }
}
