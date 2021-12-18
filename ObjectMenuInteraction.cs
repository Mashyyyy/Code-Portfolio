using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMenuInteraction : MonoBehaviour
{
    public GameObject objectMenu;
    private string[] itemDescription;
    private DialogueManager dialogueManager;

    //Opens the interactions available
    private void Start()
    {
        dialogueManager = FindObjectOfType<DialogueManager>();
    }
    public void OnClick_Interact()
    {
        objectMenu.SetActive(true);
        objectMenu.transform.position = new Vector2(Input.mousePosition.x, 228f);
    }

    public string updateItemDescription(string[] sentences)
    {
        itemDescription = sentences;
        return itemDescription[0];
    }

    //Deactivate object if un-focused
    public void OnExitObject_DeFocus()
    {
        objectMenu.SetActive(false);
    }


    public void OnClick_Examine()
    {
        objectMenu.SetActive(false);
        dialogueManager.GetSpeechDataSingle(itemDescription);
        dialogueManager.Run();
    }

    public void OnClick_Combine()
    {
        objectMenu.SetActive(false);
    }

    public void OnClick_Use()
    {
        objectMenu.SetActive(false);
    }
}