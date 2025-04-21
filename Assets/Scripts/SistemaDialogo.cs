using UnityEngine;

public class SistemaDialogo
{

    public void Talk(string mensaje)
    {
        Debug.Log(mensaje);
    }

    public void Talk(string personaje, string mensaje, string emocion)
    {
        Debug.Log(personaje + " (" + emocion + "): " + mensaje);
    }

}
