using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI damageTxt;
    [SerializeField] private TextMeshProUGUI defenceTxt;
    [SerializeField] private TextMeshProUGUI hpTxt;

    public void SetCharacterInfo(Character character)
    {
        damageTxt.text = $"Damage :{character.Damage} ";
        defenceTxt.text = $"Defence : {character.Defense}";
        hpTxt.text = $"HP : {character.HP}";
    }

}
