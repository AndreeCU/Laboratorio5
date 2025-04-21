using UnityEngine;

public class GameMananger : MonoBehaviour
{
    public SistemaInventario inventario = new SistemaInventario();
    public SistemaDialogo sistemaDialogo = new SistemaDialogo();
    public PersonajePrincipal personaje = new PersonajePrincipal();

    void Start()
    {

        Items item1 = new("Globes");
        Items item2 = new("Armor", TypeOfItem.Armor);
        Items item3 = new("Potion", TypeOfItem.Consumable);
        Items item4 = new("Bread", TypeOfItem.Consumable);
        Items item5 = new("Sword", TypeOfItem.Weapon);

        inventario.Add(item1);
        inventario.Add(item1, 10);
        inventario.Add(item2);
        inventario.Add(item3, 5);
        inventario.Add(item4, 10);
        inventario.Add(item5, TypeOfItem.Weapon, 3);

        inventario.ShowAllItems();


        sistemaDialogo.Talk("¡Hola, aventurero!");
        sistemaDialogo.Talk("NPC", "Bienvenido aventurero, un gusto conocerte", "feliz");


        personaje.vida = 100;
        Debug.Log("Vida inicial: " + personaje.vida);
        personaje.GetDamage(20);
        Debug.Log("Vida tras daño normal: " + personaje.vida);
        personaje.GetDamage(20, 50, true);
        Debug.Log("Vida tras posible crítico + knockback: " + personaje.vida);


        Slimes slime1 = new Slimes(100, "verde");
        Slimes slime2 = new Slimes(200, "rojo");
        Slimes slime3 = slime1 + slime2;

        Debug.Log("La vida del slime 1 es: " + slime1.vida);
        Debug.Log("La vida del slime 2 es: " + slime2.vida);
        Debug.Log("La vida del slime 3 es: " + slime3.vida);

    }
}