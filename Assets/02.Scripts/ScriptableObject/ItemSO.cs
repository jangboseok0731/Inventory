using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum itemType
{
    None,
    Damage,
    Defence,
}


[CreateAssetMenu(fileName ="NewItem", menuName = "Item")]
public class ItemData : ScriptableObject
{
    public string itemName; 
    public Sprite icon;     
    public int damageBonus; 
    public int defenceBonus;
}