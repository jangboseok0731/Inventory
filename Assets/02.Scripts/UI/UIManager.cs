using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class UIManager : MonoBehaviour
{
    private static UIManager instance;
    public static UIManager Instance { get { return instance; } }

    [SerializeField] private UIMainMenu mainMenu;
    [SerializeField] private UIStatus status;
    [SerializeField] private UIInventory inventory;

    public UIMainMenu MainMenu { get { return mainMenu; } }
    public UIStatus Status { get { return status; } }
    public UIInventory Inventory { get { return inventory; } }


    private void Awake()
    {
        if(Instance != null)
        {
            instance = this;
        }
        else Destroy(gameObject);
    }


}
