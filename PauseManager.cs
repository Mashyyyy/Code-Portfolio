using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenu;


    bool alreadyPaused;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!alreadyPaused)
            {
                Time.timeScale = 0;
                pauseMenu.SetActive(true);
                alreadyPaused = true;
            }
            else
            {
                Time.timeScale = 1;
                pauseMenu.SetActive(false);
                alreadyPaused = false;
            }
        }
    }

    public void OnClick_Home()
    {
        var save = FindObjectOfType<AutoSave>();
        save.SaveData();
        SceneManager.LoadScene("MainMenu");
    }

    public void OnClick_Options()
    {
        //No options
    }

    public void OnClick_Return()
    {
        alreadyPaused = false;
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
}