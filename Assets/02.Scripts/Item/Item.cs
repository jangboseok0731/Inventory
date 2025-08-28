using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item
{
    public ItemData Data;
    public int Count;

    public Item(ItemData data, int count)
    {
        Data = data;
        Count = count;
    }
}
