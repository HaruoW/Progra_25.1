public abstract class Enemigo
{
    protected int vida;
    protected int daño;

    public Enemigo(int vida, int daño)
    {
        this.vida = vida;
        this.daño = daño;
    }

    public void RecibirDaño(int cantidad)
    {
        vida -= cantidad;
        if (vida < 0) vida = 0;
    }

    public abstract int ObtenerDaño(); 
    public bool EstaVivo() => vida > 0;
    public int ObtenerVida() => vida;
}
