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

    private Item item;
    private int count;

    public void SetItem(Item newItem, int itemCount)
    {
        item = newItem;
        RefreshUI();


    }
    public void RefreshUI()
    {
        if(item != null)
        {
            icon.sprite = item.Icon;
        }
        else
        {
            icon.sprite=null;
        }
    }
    
}
