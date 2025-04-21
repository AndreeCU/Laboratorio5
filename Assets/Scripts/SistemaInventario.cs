using UnityEngine;
using System.Collections.Generic;

public class SistemaInventario
{

    private Dictionary<Items, int> inventory = new Dictionary<Items, int>();

    public void Add(Items _item)
    {
        if (inventory.ContainsKey(_item))
        {
            inventory.TryGetValue(_item, out int value);
            int tempValue = value + 1;

            inventory[_item] = tempValue;
        }
        else
            inventory.Add(_item, 1);
    }

    public void Add(Items _item, TypeOfItem _typeOfItem)
    {
        _item.SetType(_typeOfItem);
        Add(_item);
    }

    public void Add(Items _item, int quantity)
    {
        if (inventory.ContainsKey(_item))
        {
            inventory.TryGetValue(_item, out int value);
            int tempValue = value + quantity;
        }
        else
            inventory.Add(_item, quantity);

    }

    public void Add(Items _item, TypeOfItem _typeOfItem, int _quantity)
    {
        _item.SetType(_typeOfItem);
        Add(_item, _quantity);
    }

    public void ShowAllItems()
    {
        foreach (var slot in inventory)
        {
            Debug.Log("El item " + slot.Key.ItemName + "Con la cantidad " + slot.Value);
        }
    }
}