using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    [Header("GameOver")]
    [SerializeField] public GameObject gameoverMenu;
    public PlayerController playerController;

    private void Awake()
    {
        instance = this;
    }

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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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

