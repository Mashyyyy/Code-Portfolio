using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button continueButton;
    public Texture2D cursorDefault;
    public Animator fadeAnim;
    int currentLevelToLoad;
    public InventoryContainer playerInventory;
    bool canLoadALevel = false;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("currentLevelLoad"))
        {
            currentLevelToLoad = PlayerPrefs.GetInt("currentLevelLoad");
        }
        else
        {
            currentLevelToLoad = 0;
        }
        if (currentLevelToLoad >= 3)
        {
            continueButton.interactable = true;
            //currentLevelToLoad = currentLevel;
            canLoadALevel = true;
        }
    }

    public void OnClick_Continue()
    {
        StartCoroutine(continueGame());
    }

    public void OnClick_New()
    {
        /*
        if (canLoadALevel)
        {
            //Warns the user that the savefile can ba overwritten
        }
        else
        {
            StartCoroutine(initiateLaunch());
        }
        */
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
        playerInventory.Container.Clear();
        StartCoroutine(initiateLaunch());
    }

    IEnumerator initiateLaunch()
    {
        fadeAnim.gameObject.SetActive(true);
        fadeAnim.SetTrigger("FadeOut");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("IntroCutscene");
    }

    IEnumerator continueGame()
    {
        fadeAnim.gameObject.SetActive(true);
        fadeAnim.SetTrigger("FadeOut");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(currentLevelToLoad);
    }


    public void OnClick_Exit()
    {
        Application.Quit();
    }
}