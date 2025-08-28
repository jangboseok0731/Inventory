using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public Sprite Icon;
    public int Count;

    public Item(Sprite icon, int count)
    {
        Icon = icon;
        Count = count;
    }
}
