using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fTrigger2 : MonoBehaviour
{
    public DialogueManager dialogueManager;
    public InventoryContainer playerInventory;
    public string[] sentences;
    public int index;
    private bool inDialogue = false;

    [SerializeField]
    private Texture2D cursorInspect;
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

    public Item photoItem2;
    public GameObject buttonObject;
    public GameObject poiIcon;

    private void Awake()
    {
        point = GetComponent<Transform>();
    }

    private void Update()
    {
        inDialogue = dialogueManager.dialogueActive;
        isActive = Physics2D.OverlapCircle(point.transform.position, radius, layerMask);

        if (isActive)
        {
            poiIcon.SetActive(true);
        }
        else
        {
            poiIcon.SetActive(false);
        }
    }

    public void OnClick_Speech()
    {
        if (!inDialogue)
        {
            if (isActive)
            {
                if (!dialogueDone)
                {
                    string matchItemName = "Teddy Bear";
                    bool hasFound = false;
                    for (int i = 0; i < playerInventory.Container.Count; i++)
                    {
                        if (matchItemName == playerInventory.Container[i].item.itemName)
                        {
                            var displayInventory = FindObjectOfType<DisplayInventory>();
                            displayInventory.RemoveFromInventory(i);
                            playerInventory.AddItem(photoItem2.itemInfo, 1);
                            Destroy(buttonObject);
                            
                            hasFound = true;
                        }
                    }
                    if (hasFound)
                    {
                        dialogueManager.GetSpeechData(sentences, index);
                        dialogueManager.Run();
                        
                        
                        if(PlayerPrefs.GetInt("CluesFound") == 0)
                        {
                            PlayerPrefs.SetInt("CluesFound", 1);
                        }
                        else if(PlayerPrefs.GetInt("CluesFound") == 1)
                        {
                            PlayerPrefs.SetInt("CluesFound", 2);
                        }
                        PlayerPrefs.Save();
                        
                    }
                    dialogueDone = true;
                }
            }
            else
                Debug.Log("Too far away.");
        }
    }

    public void OnHover_Mouse()
    {
        Cursor.SetCursor(cursorGrab, Vector2.zero, CursorMode.Auto);
    }

    public void UnHover_Mouse()
    {
        Cursor.SetCursor(cursorDefault, Vector2.zero, CursorMode.Auto);
    }
}