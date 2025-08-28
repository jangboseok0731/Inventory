using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private Button mainToInvenButton;
    [SerializeField] private Button mainToStatButton;
    [SerializeField] private Button inventoryButton;
    [SerializeField] private Button statusButton;


    private void Start()
    {
        mainToInvenButton.onClick.AddListener(ShowMain);
        mainToStatButton.onClick.AddListener(ShowMain);
        inventoryButton.onClick.AddListener(ShowInventory);
        statusButton.onClick.AddListener(ShowStatus);
    }
    public void ShowMain()
    {
        UIManager.Instance.MainMenu.gameObject.SetActive(true);
        UIManager.Instance.Status.gameObject.SetActive(false);
        UIManager.Instance.Inventory.gameObject.SetActive(false);
    }
    public void ShowInventory()
    {
        UIManager.Instance.MainMenu.gameObject.SetActive(false);
        UIManager.Instance.Status.gameObject.SetActive(false);
        UIManager.Instance.Inventory.gameObject.SetActive(true);

        UIManager.Instance.Inventory.GetComponent<UIInventory>().RefreshInventoryUI();
    }
    public void ShowStatus()
    {
        UIManager.Instance.MainMenu.gameObject.SetActive(false);
        UIManager.Instance.Status.gameObject.SetActive(true);
        UIManager.Instance.Inventory.gameObject.SetActive(false);
    }


}
