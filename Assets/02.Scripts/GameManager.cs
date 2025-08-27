using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private UIManager uiManager;
    [SerializeField] private Character Character;

    private void Awake()
    {
        if(Instance != null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        
    }
}
