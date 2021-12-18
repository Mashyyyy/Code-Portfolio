using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FinalDoorTrigger : MonoBehaviour
{
    public Texture2D cursorDefault, cursorInspect;
    public GameObject whereToGo;
    private GameManager gameManager;
    private LoadTrigger loadTrigger;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        loadTrigger = FindObjectOfType<LoadTrigger>();
    }

    public void Hover_Mouse()
    {
        Cursor.SetCursor(cursorInspect, Vector2.zero, CursorMode.Auto);
    }

    public void UnHover_Mouse()
    {
        Cursor.SetCursor(cursorDefault, Vector2.zero, CursorMode.Auto);
    }

    public void Click_Mouse()
    {
        OnClick_Active();
    }

    void OnClick_Active()
    {
        var player = FindObjectOfType<PlayerMovement>();
        player.enabled = false;
        player.gameObject.GetComponent<AudioSource>().Stop();
        player.gameObject.GetComponent<Animator>().SetBool("isWalking", false);
        loadTrigger.isAlreadyActive = true;
        whereToGo.SetActive(true);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(PlayerPrefs.GetInt("CluesFound") != 2)
            {
                collision.gameObject.GetComponent<PlayerMovement>().enabled = false;
                collision.gameObject.GetComponent<AudioSource>().Stop();
                collision.gameObject.GetComponent<Animator>().SetBool("isWalking", false);
                loadTrigger.isAlreadyActive = true;
                whereToGo.SetActive(true);
            }
            else if(PlayerPrefs.GetInt("CluesFound") == 2)
            {
                SceneManager.LoadScene("FinalLimboLevel");
            }
        }
    }

    public void Reactivate()
    {
        var player = FindObjectOfType<PlayerMovement>();
        player.enabled = true;
        whereToGo.SetActive(false);
    }

    public void loadToLevel(string sceneName)
    {
        StartCoroutine(gameManager.loadSpecificLevel(sceneName));
    }
}