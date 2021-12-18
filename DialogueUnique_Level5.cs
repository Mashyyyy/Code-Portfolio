using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueUnique_Level5 : MonoBehaviour
{
    public DialogueManager dialogueManager;
    public InventoryContainer playerInventory;
    public string[] sentences;
    public int index;
    private bool inDialogue = false;

    [SerializeField]
    private Texture2D cursorSpeech;
    [SerializeField]
    private Texture2D cursorDefault;
    [SerializeField]
    private Texture2D cursorGrab;

    private Transform point;
    [SerializeField]
    private float radius;
    [SerializeField]
    private LayerMask layerMask;

    private bool isActive;
    private bool dialogueDone;
    private bool dialogue2Done;

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
                if (!dialogueDone)
                {
                    dialogueManager.GetSpeechData(sentences, index);
                    dialogueManager.Run();
                    dialogueDone = true;
                    dialogue2Done = false;
                }
                else
                {
                    if (!dialogue2Done)
                    {
                        string matchItemName = "Loaf of Bread";
                        bool hasFound = false;
                        for (int i = 0; i < playerInventory.Container.Count; i++)
                        {
                            if (matchItemName == playerInventory.Container[i].item.itemName)
                            {
                                var displayInventory = FindObjectOfType<DisplayInventory>();
                                displayInventory.RemoveFromInventory(i);
                                hasFound = true;
                            }
                        }
                        if (!hasFound)
                        {
                            string[] sentence = { "???: yOu hAVe nO BrEAd..", "???: vErY uNFOrtuNaTE..." };
                            dialogueManager.GetSpeechData(sentence, 0);
                            dialogueManager.Run();
                        }
                        else
                        {
                            string[] sentence = { "???: thAnK yoU For tHE BrEAD..",
                                                  "???: I cAn SeE yoUr shadOWy friend...","???: I CAn feEl a sImiLaRiTY to YoU...","???: HOw pEcUliAr..."};
                            dialogueManager.GetSpeechData(sentence, 0);
                            dialogueManager.Run();
                            var gameManager = FindObjectOfType<GameManager>();
                            gameManager.givenBread = true;
                        }
                        dialogue2Done = true;
                        dialogueDone = false;
                    }
                }
            }
            else
                Debug.Log("Too far away.");
        }
    }

    public void OnHover_Mouse()
    {
        if(!dialogueDone)
            Cursor.SetCursor(cursorSpeech, Vector2.zero, CursorMode.Auto);
        else
            Cursor.SetCursor(cursorGrab, Vector2.zero, CursorMode.Auto);
    }

    public void UnHover_Mouse()
    {
        Cursor.SetCursor(cursorDefault, Vector2.zero, CursorMode.Auto);
    }
}