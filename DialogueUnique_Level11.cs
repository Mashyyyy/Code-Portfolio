using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueUnique_Level11 : MonoBehaviour
{
    public DialogueManager dialogueManager;
    public string[] sentences;
    public int index;
    private bool inDialogue = false;
    public GameObject faintVoice;

    [SerializeField]
    private Texture2D cursorSpeech;
    [SerializeField]
    private Texture2D cursorDefault;

    private Transform point;
    [SerializeField]
    private float radius;
    [SerializeField]
    private LayerMask layerMask;

    private bool isActive;
    private bool isDialogueDone = false;
    private void Awake()
    {
        point = GetComponent<Transform>();
    }

    private void Update()
    {
        inDialogue = dialogueManager.dialogueActive;
        /*
        if (!inDialogue)
        {
            if (isDialogueDone)
            {
                var gameManager = FindObjectOfType<GameManager>();
                gameManager.LoadToNextLevel();
            }
        }
        */
        isActive = Physics2D.OverlapCircle(point.transform.position, radius, layerMask);
    }

    public void OnClick_Speech()
    {
        if (!inDialogue)
        {
            if (isActive)
            {
                dialogueManager.GetSpeechData(sentences, index);
                dialogueManager.Run();
                faintVoice.SetActive(true);
                isDialogueDone = true;
                var gameManager = FindObjectOfType<GameManager>();
                gameManager.dialogueFinished12 = true;
                gameManager.canLoadToNextLevel = true;
            }
            else
                Debug.Log("Too far away.");
        }
    }

    public void OnHover_Mouse()
    {
        Cursor.SetCursor(cursorSpeech, Vector2.zero, CursorMode.Auto);
    }

    public void UnHover_Mouse()
    {
        Cursor.SetCursor(cursorDefault, Vector2.zero, CursorMode.Auto);
    }
}