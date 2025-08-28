using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    //UI구성요소에 연결될 필드 추가 (시리얼라이즈필드)
    //셋아이템,리프레쉬유아이 메서드 추가.

    [SerializeField] private Image icon;
    [SerializeField] private Button button;

    private Item item;

    public void SetItem(Item newItem, int itemCount)
    {
        item = newItem;
        RefreshUI();

        if(item != null)
        {
            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(() => { UIManager.Instance.Inventory.OnSlotClicked(item); });
        }
        else
        {
            button.onClick.RemoveAllListeners();
        }

    }
    public void RefreshUI()
    {
        if(item != null)
        {
            icon.sprite = item.Data.icon;
            icon.enabled = true;
        }
        else
        {
            icon.sprite=null;
            icon.enabled = false;
        }
    }

    
}
