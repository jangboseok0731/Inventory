using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class Character 
{
    public string Name { get; private set; }
    public int Damage { get; private set; }
    public int Defense { get; private set; }    
    public int Level { get; private set; }
    public int HP { get; private set; }
    public int MP { get; private set; }
    public int Exp { get; private set; }
    public int Gold { get; private set; }
    public List<Item> Inventory { get; private set; } = new List<Item>();

    public ItemData itemData;

    private Item equippedItem;

    public Character(string name,int damage,int defence, int level, int hp, int mp, int exp, int gold, List<Item> inventory)
    {
        Name = name;
        Damage = damage;
        Level = level;
        HP = hp;
        MP = mp;
        Exp = exp;
        Gold = gold;
        Defense = defence;
        Inventory = inventory;
    }
    public void Equip(Item item)
    {
        // 기존에 장착된 아이템이 있다면 해제
        if (equippedItem != null)
        {
            UnEquip(equippedItem);
        }
        // 장착
        equippedItem = item;
        Damage += item.Data.damageBonus;
        Defense += item.Data.defenceBonus;
    }
    public void UnEquip(Item item)
    {
        if (equippedItem != null)
        {
            equippedItem = null;
        }

        Damage -= item.Data.damageBonus;
        Defense -= item.Data.defenceBonus;
        equippedItem = null;
    }
    public void AddItem(Item newItem)
    {
        // 기존에 같은 아이템이 있는지 찾기 (여기서 기준은 Icon이나 이름 등)
        var existingItem = Inventory.Find(i => i.Data.name == newItem.Data.name);

        if (existingItem != null)
        {
            // 아이템 수량 증가
            existingItem.Count += newItem.Count;
        }
        else
        {
            // 새 아이템 추가
            Inventory.Add(newItem);
        }
    }


}
