public class Jugador
{
    private int vida;
    private int daño;

    public Jugador(int vida, int daño)
    {
        this.vida = Math.Min(vida, 100);
        this.daño = Math.Min(daño, 100);
    }

    public void RecibirDaño(int cantidad)
    {
        vida -= cantidad;
        if (vida < 0) vida = 0;
    }

    public int ObtenerDaño() => daño;
    public int ObtenerVida() => vida;
}
