using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fTrigger1 : MonoBehaviour
{
    public Texture2D cursorDefault, cursorInspect;
    public GameObject fPuzzle1;
    [HideInInspector]
    public bool isAlreadyActive;

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
        var player = FindObjectOfType<PlayerMovement>();
        player.enabled = false;
        player.gameObject.GetComponent<AudioSource>().Stop();
        player.gameObject.GetComponent<Animator>().SetBool("isWalking", false);
        isAlreadyActive = true;
        fPuzzle1.SetActive(true);
    }

    public void Close()
    {
        if (isAlreadyActive)
        {
            fPuzzle1.SetActive(false);
            var player = FindObjectOfType<PlayerMovement>();
            player.enabled = true;
            isAlreadyActive = false;
        }
    }
}