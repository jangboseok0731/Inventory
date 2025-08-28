using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private UISlot slotPrefab;
    [SerializeField] private Transform slotParant; // Content ¿Àºê¤Ä¤¡Æ®

    private List<UISlot> slots = new List<UISlot>();

    private void Start()
    {
        InitInventoryUI();
    }


    private void InitInventoryUI()
    {
        List<Item> playerItem = new List<Item>();
        playerItem = GameManager.Instance.Player.Inventory;

        for (int i = 0; i < playerItem.Count; i++) 
        {
            if(i >= slots.Count)
            {
                var slotObj = Instantiate(slotPrefab, slotParant);
                UISlot slot = slotObj.GetComponent<UISlot>();
                slots.Add(slot);
            }
            slots[i].SetItem(playerItem[i], playerItem[i].Count);
        }

        for (int i = playerItem.Count;i < slots.Count; i++)
        {
            slots[i].SetItem(null, 0);
        }

    }
}
