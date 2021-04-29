using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenChange : MonoBehaviour
{
    public static bool gamepause;
    public GameObject pausemenu; 
    private void Start()
    {
        pausemenu.SetActive(false);
    }

    public void PauseMenu()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0;
        gamepause = true;
    }
    public void ResumeGame()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1;
        gamepause = false;
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void TryAgain()
    {
        SceneManager.LoadScene(1);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamepause)
            {
                ResumeGame();
            }
            else
            {
                PauseMenu();
            }
        }
    }
    public void LoadMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
