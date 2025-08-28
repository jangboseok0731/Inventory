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
        List<Item> startingItem = new List<Item>
        {

        };
        Player = new Character("ภüป็",10,4,3,100,80,0,200000, startingItem);
        UIManager.Instance.Status.SetCharacterInfo(Player);
    }
}
