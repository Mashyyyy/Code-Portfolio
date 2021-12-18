using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour
{
    public DialogueManager dialogueManager;
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
    }

    private void Update()
    {
        inDialogue = dialogueManager.dialogueActive;
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
                var gameManager = FindObjectOfType<GameManager>();
                switch (gameManager.currentLevel)
                {
                    case 3:
                        {
                            gameManager.canLoadToNextLevel = true;
                            break;
                        }
                    case 5:
                        {
                            gameManager.canLoadToNextLevel = true;
                            break;
                        }
                    case 6:
                        {
                            gameManager.canLoadToNextLevel = true;
                            break;
                        }
                    case 7:
                        {
                            gameManager.canLoadToNextLevel = true;
                            break;
                        }
                    case 9:
                        {
                            gameManager.canLoadToNextLevel = true;
                            break;
                        }
                    case 10:
                        {
                            gameManager.canLoadToNextLevel = true;
                            break;
                        }
                    case 11:
                        {
                            gameManager.canLoadToNextLevel = true;
                            break;
                        }
                }
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