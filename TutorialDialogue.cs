using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialDialogue : MonoBehaviour
{
    public DialogueManager dialogueManager;
    private GameManager gameManager;
    public string[] sentences;
    public int index;
    private bool inDialogue = false;

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


    private void Awake()
    {
        point = GetComponent<Transform>();
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        inDialogue = dialogueManager.dialogueActive;
        isActive = Physics2D.OverlapCircle(point.transform.position, radius, layerMask);
    }


    bool alreadyDone = false;
    public void OnClick_Speech()
    {
        if (!inDialogue)
        {
            if (isActive)
            {
                dialogueManager.GetSpeechData(sentences, index);
                dialogueManager.Run();
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