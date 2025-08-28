using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private UISlot slotPrefab;
    [SerializeField] private Transform slotParant; // Content 오브ㅔㄱ트
    [SerializeField] private Button equipButton;
    [SerializeField] private Button unEquipButton;

    private List<UISlot> slots = new List<UISlot>();
    private Item selectedItem;



    private void Start()
    {
        InitInventoryUI();
        Debug.Log($"Player.Inventory 개수: {GameManager.Instance.Player.Inventory.Count}");
        equipButton.onClick.AddListener(OnEquipButton);
        unEquipButton.onClick.AddListener(OnUnEquipButton);

    }
    public void RefreshInventoryUI()
    {
        foreach (var slot in slots)
        {
            Destroy(slot.gameObject);
        }
        slots.Clear();
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
    public void OnSlotClicked(Item item)
    {
        selectedItem = item;
        Debug.Log(item.Data.itemName + " 선택됨");
    }

    public void OnEquipButton()
    {
        if (selectedItem != null)
        {
            GameManager.Instance.Player.Equip(selectedItem);
            UIManager.Instance.Status.SetCharacterInfo(GameManager.Instance.Player);
        }
    }

    public void OnUnEquipButton()
    {
        if (selectedItem != null)
        {
            GameManager.Instance.Player.UnEquip(selectedItem);
            UIManager.Instance.Status.SetCharacterInfo(GameManager.Instance.Player);
        }
    }
}
