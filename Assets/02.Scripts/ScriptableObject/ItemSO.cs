using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="NewItem", menuName = "Item")]
public class ItemData : ScriptableObject
{
    public string itemName; 
    public Sprite icon;     
    public int damageBonus; 
    public int defenceBonus;
}