using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] string _levelName;
    string _menu = "Menu";

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }

    public void GoTolevel()
    {
        SceneManager.LoadScene(_levelName);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(_menu);
    }

    public void SleaseModeActive()
    {
        SleaseMode.sleaseMode();
    }
}
