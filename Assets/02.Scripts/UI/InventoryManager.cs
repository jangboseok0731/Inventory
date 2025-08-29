using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public List<ItemData> allItemData; // �ν����Ϳ� �ֱ�
    List<Item> inventory = new List<Item>();

    void Start()
    {
        AddRandomItems(4); // 5�� ������ ���� �߰�
        DebugInventory();  // Ȯ�ο�
    }

    void AddRandomItems(int count)
    {
        for (int i = 0; i < count; i++)
        {
            var randomItem = allItemData[Random.Range(0, allItemData.Count)];
            // ���� ����
            int qty = Random.Range(1, 5);
            inventory.Add(new Item(randomItem, qty));
        }
    }

    void DebugInventory()
    {
        foreach (var item in inventory)
        {
            Debug.Log($"Item: {item.Data.itemName}, Count: {item.Count}");
        }
    }
}
