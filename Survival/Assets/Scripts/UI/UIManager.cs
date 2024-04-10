using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    [Header("GameOver")]
    [SerializeField] public GameObject gameoverMenu;
    public PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        gameoverMenu.SetActive(false);

    }
    public void GameOver()
    {
        gameoverMenu.SetActive(true);
        //Cursor.lockState = CursorLockMode.None;
    }
    public void Reiniciar()
    {
        Debug.Log(playerController);
        playerController.SavePlayerPosition();
        playerController.LoadPlayerPosition();
        gameoverMenu.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif

    }
}

