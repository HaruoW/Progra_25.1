public class EnemigoRango : Enemigo
{
    private int balas;

    public EnemigoRango(int vida, int daño, int balas) : base(vida, daño)
    {
        this.balas = balas;
    }

    public override int ObtenerDaño()
    {
        if (balas > 0)
        {
            balas--;
            return daño;
        }
        return 0; 
    }

    public int ObtenerBalas() => balas;
}
