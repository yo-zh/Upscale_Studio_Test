using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayNewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadGame(int SaveCell)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // template, replace with real saves
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
