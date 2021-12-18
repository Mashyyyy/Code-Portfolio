using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastCollect : MonoBehaviour
{
    public InventoryContainer playerInven;

    private Transform point;
    [SerializeField]
    private float radius;
    [SerializeField]
    private LayerMask layerMask;

    private bool isActive;

    [SerializeField]
    private Texture2D inspectCursor;
    [SerializeField]
    private Texture2D grabCursor;
    [SerializeField]
    private Texture2D defaultCursor;

    private DialogueManager dialogue;

    private void Start()
    {
        point = GetComponent<Transform>();
        dialogue = FindObjectOfType<DialogueManager>();
    }

    private void Update()
    {
        isActive = Physics2D.OverlapCircle(point.position, radius, layerMask);
    }


    //Clicked / Obtained the Object
    public void OnClick_GetObject()
    {
        var gameManager = FindObjectOfType<GameManager>();
        if (isActive)
        {
            var item = GetComponent<Item>();
            playerInven.AddItem(item.itemInfo, 1);
            Cursor.SetCursor(defaultCursor, Vector2.zero, CursorMode.Auto);
            switch (gameManager.currentLevel)
            {
                case 3:
                    {
                        gameManager.gotBread = true;
                        break;
                    }
            }

            string[] sentences = {"All three photos you found fitted perfectly in the torn parts in the scrapbook",
                                  "You realized now that there were pictures of you, and that isn't your scrapbook..." };
            int index = 0;
            dialogue.GetSpeechData(sentences, index);
            dialogue.Run();
            gameManager.dialogueFinishedF = true;
            Destroy(this.gameObject);
        }
        else
        {
            Debug.Log("Player cannot reach that object.");
        }
    }


    //Entered in the trigger zone
    public void OnHover_Object()
    {
        if (isActive)
        {
            Cursor.SetCursor(grabCursor, Vector2.zero, CursorMode.Auto);
        }
        else
        {
            Cursor.SetCursor(inspectCursor, Vector2.zero, CursorMode.Auto);
        }
    }

    //Exited in the trigger zone
    public void OnUnHover_Object()
    {
        Cursor.SetCursor(defaultCursor, Vector2.zero, CursorMode.Auto);
    }
}