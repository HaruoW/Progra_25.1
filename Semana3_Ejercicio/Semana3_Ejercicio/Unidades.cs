namespace Unidades
{

    public abstract class Unidades
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }
        public int Daño { get; set; }

       
        public Unidades(string nombre, int vida, int daño)
        {
            Nombre = nombre;
            Vida = vida;
            Daño = daño;
        }


        public virtual void Atacar(Unidades objetivo)
        {
            if (objetivo != null)
            {
                objetivo.RecibirDaño(Daño);
            }
        }


        public virtual void RecibirDaño(int cantidad)
        {
            Vida -= cantidad;
        }
    }


    public class Soldado : Unidades
    {
        public Soldado() : base("Soldado", 50, 10) { }
    }


    public class Arquero : Unidades
    {
        public Arquero() : base("Arquero", 70, 20) { }
    }
}
