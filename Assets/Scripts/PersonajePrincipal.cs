using UnityEngine;
using UnityEngine.Video;

public class PersonajePrincipal
{

    public int vida = 100;
    public void GetDamage(int daño)
    {
        vida -= daño;
    }

    public void GetDamage(int damage, int critProb, bool knockback)
    {
        if (Random.Range(0, 50) <= critProb)
            vida -= damage * 2;

        if (knockback)
        {
            Debug.Log("Fue afectado por el retroceso");
        }


    }


}