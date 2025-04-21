using UnityEngine;

public class Slimes
{

    public int vida;
    public string color;

    public Slimes()
    {
        vida = 200;
        color = "verde";
    }

    public Slimes(int vida)
    {
        this.vida = vida;
        color = "verde";
    }

    public Slimes(int vida, string color)
    {
        this.vida = vida;
        this.color = color;
    }



    public static Slimes operator +(Slimes a, Slimes b)
    {
        return new Slimes(a.vida + b.vida);
    }
    public static Slimes operator -(Slimes a, int daño)
    {
        return new Slimes(a.vida - daño);
    }

    public static bool operator ==(Slimes a, Slimes b)
    {
        return a.vida == b.vida;
    }

    public static bool operator !=(Slimes a, Slimes b)
    {
        return a.vida != b.vida;
    }


}
