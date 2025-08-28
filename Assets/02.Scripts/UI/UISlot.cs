using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    //UI������ҿ� ����� �ʵ� �߰� (�ø���������ʵ�)
    //�¾�����,�������������� �޼��� �߰�.

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
