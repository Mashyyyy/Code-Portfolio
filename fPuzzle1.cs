using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class fPuzzle1 : MonoBehaviour
{
    public List<TMP_InputField> Keys;
    public List<string> keyPass;
    public Button acceptButton;
    public GameObject locked, unlocked;
    public InventoryContainer playerInven;
    public Item photoItem1;
    public GameObject padlockScreen;

    public string[] sentences;
    public int index;

    public void Accept_Button()
    {
        for (int i = 0; i < Keys.Count; i++)
        {
            keyPass[i] = Keys[i].text;
        }
        ReadInput();
    }

    void ReadInput()
    {
        if(keyPass[0] == "1" && 
           keyPass[1] == "1" && 
           keyPass[2] == "2" && 
           keyPass[3] == "0")
        {
            
            if(PlayerPrefs.GetInt("CluesFound") == 0)
            {
                PlayerPrefs.SetInt("CluesFound", 1);
                PlayerPrefs.Save();
            }
            else if(PlayerPrefs.GetInt("CluesFound") == 1)
            {
                PlayerPrefs.SetInt("CluesFound", 2);
                PlayerPrefs.Save();
            }
            playerInven.AddItem(photoItem1.itemInfo, 1);
            locked.SetActive(false);
            unlocked.SetActive(true);
            padlockScreen.SetActive(false);
            var player = FindObjectOfType<PlayerMovement>();
            player.enabled = true;
            var dialogue = FindObjectOfType<DialogueManager>();
            dialogue.GetSpeechData(sentences, index);
            dialogue.Run();
            Destroy(this);
            Debug.Log("KeyPass Accepted");
        }
        else
        {
            Debug.Log("KeyPass Wrong");
        }
    }

    public void Click_Close()
    {
        var fTrigger = FindObjectOfType<fTrigger1>();
        fTrigger.Close();
    }
}