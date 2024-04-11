using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public TextMeshProUGUI enemyStatus;

    private void Awake()
    {
        Instance = this;
    }

    public void UpdateText(string txt)
    {
        enemyStatus.text = txt;
    }
}
