using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
     public GameObject homeMenu;
    public GameObject settingMenu;
    public GameObject pauseMenu;
    public GameObject playGame;
    public static bool isRestarting = false;
    
    // Start is called before the first frame update
    void Start()
    {
        if (isRestarting)
        {
            homeMenu.SetActive(false);
            settingMenu.SetActive(false);
            pauseMenu.SetActive(false);
            playGame.SetActive(true);  
        }
        else
        {
            homeMenu.SetActive(true);
            settingMenu.SetActive(false);
            pauseMenu.SetActive(false);
            playGame.SetActive(false);
        }
    }

    public void GameStart()
    {
        homeMenu.SetActive(false);
        playGame.SetActive(true);
        // AudioManager.instance.ButtonSound();
    }

    public void SettingGame()
    {
        settingMenu.SetActive(true);
        // AudioManager.instance.ButtonSound();
    }
    public void QuitGame()
    {
        Application.Quit();
        // AudioManager.instance.ButtonSound();
    }

    public void PauseGame()
    {
        playGame.SetActive(true);
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        // AudioManager.instance.ButtonSound();
    }

    public void ResumeGame()
    {
       
        pauseMenu.SetActive(false);
        playGame.SetActive(true);
        Time.timeScale = 1;
        // AudioManager.instance.ButtonSound();
    }

    public void MainMenu()
    {
        homeMenu.SetActive(true);
        playGame.SetActive(false);
        // AudioManager.instance.ButtonSound();
        settingMenu.SetActive(false);
    }
    public void RestartGame()
    {
        Time.timeScale = 1;
        // AudioManager.instance.ButtonSound();

    }
    public void Restart()
    {
        Time.timeScale = 1f;
        isRestarting = true;
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // AudioManager.instance.ButtonSound();

    }
    public void goHome()
    {
        isRestarting = false;
        Time.timeScale = 1f;
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // AudioManager.instance.ButtonSound();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
