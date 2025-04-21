using UnityEngine;


public enum TypeOfItem
{
    none,
    Armor,
    Weapon,
    Consumable,
    Enchansment
}
public class Items
{
    private TypeOfItem typeOfItem = TypeOfItem.none;
    private string itemName = "";

    public TypeOfItem TypeOfItem => typeOfItem;
    public string ItemName => itemName;

    public Items()
    {
        typeOfItem = TypeOfItem.none;
        itemName = "";
    }
    public Items(string _itemName)
    {
        typeOfItem = TypeOfItem.none;
        itemName = _itemName;
    }
    public Items(string _itemName, TypeOfItem _typeOfItem)
    {
        itemName = _itemName;
        typeOfItem = _typeOfItem;
    }

    public void SetType(TypeOfItem _typeOfItem)
    {
        typeOfItem = _typeOfItem;
    }
}