using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [Header("UI Panels")]
    [SerializeField] private GameObject pauseMenuUI;   
    [SerializeField] private GameObject soundMenuUI;   

    private bool isPaused = false;

    void Start()
    {
        
        if (pauseMenuUI != null) pauseMenuUI.SetActive(false);
        if (soundMenuUI != null) soundMenuUI.SetActive(false);

        Time.timeScale = 1f; 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           
            if (soundMenuUI != null && soundMenuUI.activeSelf)
            {
                soundMenuUI.SetActive(false);
                if (pauseMenuUI != null) pauseMenuUI.SetActive(true);
                return;
            }

            
            if (isPaused) Resume();
            else Pause();
        }
    }

    public void Resume()
    {
        if (pauseMenuUI != null) pauseMenuUI.SetActive(false);
        if (soundMenuUI != null) soundMenuUI.SetActive(false);

        Time.timeScale = 1f;
        isPaused = false;
    }

    public void Pause()
    {
        if (pauseMenuUI != null) pauseMenuUI.SetActive(true);
        if (soundMenuUI != null) soundMenuUI.SetActive(false);

        Time.timeScale = 0f;
        isPaused = true;
    }

    public void OpenSoundMenu()
    {
        Debug.Log("Sound Settings button pressed!");
        if (soundMenuUI != null)
        {
            soundMenuUI.SetActive(true);
            if (pauseMenuUI != null) pauseMenuUI.SetActive(false);
        }
        else
        {
            Debug.LogWarning("SoundMenu reference is missing!");
        }
    }

    public void BackToPauseMenu()
    {
        if (soundMenuUI != null) soundMenuUI.SetActive(false);
        if (pauseMenuUI != null) pauseMenuUI.SetActive(true);
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}