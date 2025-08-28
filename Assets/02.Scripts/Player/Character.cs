using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class Character : MonoBehaviour
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
        // ������ ������ �������� �ִٸ� ����
        if (equippedItem != null)
        {
            UnEquip();
        }

        // ����
        equippedItem = item;
    }
    public void UnEquip()
    {
        if (equippedItem != null)
        {
            equippedItem = null;
        }
    }
    public void AddItem(Item newItem)
    {
        // ������ ���� �������� �ִ��� ã�� (���⼭ ������ Icon�̳� �̸� ��)
        var existingItem = Inventory.Find(i => i.Icon == newItem.Icon);

        if (existingItem != null)
        {
            // ������ ���� ����
            existingItem.Count += newItem.Count;
        }
        else
        {
            // �� ������ �߰�
            Inventory.Add(newItem);
        }
    }


}
