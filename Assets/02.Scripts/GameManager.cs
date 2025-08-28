using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    [SerializeField] private UIManager uiManager;
    [SerializeField] private Character Character;

    public Character Player { get; private set; }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        SetData();
    }
    public void SetData()
    {
        List<Item> startingItem = new List<Item>();
        ItemData swordData = Resources.Load<ItemData>("Items/Sword");
        ItemData dok2Data = Resources.Load<ItemData>("Items/Dok2");
        ItemData bowCowData = Resources.Load<ItemData>("Items/BowCow");

        // 아이템 넣기
        startingItem.Add(new Item(swordData, 1));
        startingItem.Add(new Item(dok2Data, 2));
        startingItem.Add(new Item(bowCowData, 3));

        Player = new Character("전사", 10, 4, 3, 100, 80, 0, 200000, startingItem);
        UIManager.Instance.Status.SetCharacterInfo(Player);
    }

}
