using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [Header("UI Panels")]
    [SerializeField] private GameObject playMenuUI;        
    [SerializeField] private GameObject optionsMenuUI;     
    [SerializeField] private GameObject soundSettingsMenu; 

    [Header("Scene Names")]
    [SerializeField] private string gameSceneName = "GameSceneTwo"; 

    void Start()
    {
        
        if (playMenuUI != null) playMenuUI.SetActive(false);
        if (optionsMenuUI != null) optionsMenuUI.SetActive(false);
        if (soundSettingsMenu != null) soundSettingsMenu.SetActive(false);
    }

    
    public void StartNewGame()
    {
        Debug.Log("New Game button pressed!");
        Time.timeScale = 1f; 
        SceneManager.LoadScene(gameSceneName);
    }

    
    public void OpenPlayMenu()
    {
        if (playMenuUI != null) playMenuUI.SetActive(true);
        if (optionsMenuUI != null) optionsMenuUI.SetActive(false);
        if (soundSettingsMenu != null) soundSettingsMenu.SetActive(false);
    }

    public void OpenOptionsMenu()
    {
        if (optionsMenuUI != null) optionsMenuUI.SetActive(true);
        if (playMenuUI != null) playMenuUI.SetActive(false);
        if (soundSettingsMenu != null) soundSettingsMenu.SetActive(false);
    }

    public void OpenSoundSettings()
    {
        if (soundSettingsMenu != null) soundSettingsMenu.SetActive(true);
        if (optionsMenuUI != null) optionsMenuUI.SetActive(false);
        if (playMenuUI != null) playMenuUI.SetActive(false);
    }

    public void BackToMain()
    {
        if (playMenuUI != null) playMenuUI.SetActive(false);
        if (optionsMenuUI != null) optionsMenuUI.SetActive(false);
        if (soundSettingsMenu != null) soundSettingsMenu.SetActive(false);
    }

   
    public void QuitGame()
    {
        Debug.Log("Quit Game pressed.");
        Application.Quit();
    }
}