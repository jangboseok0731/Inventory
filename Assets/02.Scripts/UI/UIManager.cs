using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set ; }

    [SerializeField] private UIMainMenu mainMenu;
    [SerializeField] private UIStatus status;
    [SerializeField] private UIInventory inventory;

    public UIMainMenu MainMenu { get { return mainMenu; } }
    public UIStatus Status { get { return status; } }
    public UIInventory Inventory { get { return inventory; } }


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            //DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }


}
