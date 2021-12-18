using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region UNIVERSAl
    [Header("UNIVERSAL Properties")]
    public Animator fadeAnim;
    public int currentLevel;
    public InventoryContainer playerInventory;
    public bool canLoadToNextLevel = false;
    #endregion
    #region LEVEL_1
    [Header("LEVEL 1 Properties")]
    public GameObject bedTrigger;
    private bool dialogueFinished = false;
    #endregion
    #region LEVEL_2
    [Header("LEVEL 2 Properties")]
    public GameObject FaintVoice;
    private bool dialogueFinished2 = false;
    #endregion

    #region LEVEL_3
    [Header("LEVEL 3 Properties")]
    [SerializeField]
    private bool dialogueFinished3 = false;
    public bool gotBread;
    #endregion

    #region LEVEL_4
    [Header("LEVEL 4 Properties")]
    [SerializeField]
    private bool dialogueFinished4 = false;
    public GameObject fatherSprite;
    #endregion

    #region LEVEL_8
    [Header("LEVEL 8 Properties")]
    public GameObject instantDeathScreen;
    public GameObject Enemy;
    #endregion

    #region LEVEL_9
    [Header("LEVEL 9 Properties")]
    private bool dialogueFinished9 = false;
    #endregion

    #region LEVEL_11
    [Header("LEVEL 11 Properties")]
    public bool givenBread;
    #endregion

    #region LEVEL_12
    [Header("LEVEL 12 Properties")]
    public bool dialogueFinished12 = false;
    #endregion

    #region LEVEL_13
    [Header("LEVEL 13 Properties")]
    private bool dialogueFinished13 = false;
    #endregion

    #region LEVEL_14
    [Header("LEVEL 14 Properties")]
    private bool dialogueFinished14 = false;
    #endregion

    #region LEVEL_15
    [Header("LEVEL 15 Properties")]
    private bool dialogueFinished15 = false;
    #endregion

    #region LEVEL_16
    [Header("LEVEL 16 Properties")]
    private bool dialogueFinished16 = false;
    #endregion

    #region LEVEL_FINAL
    public bool dialogueFinishedF = false;
    #endregion

    private void Start()
    {
        switch (currentLevel)
        {
            case 2:
                {
                    StartCoroutine(moveDelay());
                    break;
                }
        }
    }
    IEnumerator moveDelay()
    {
        while (FaintVoice.transform.position.x > -8.67f)
        {
            FaintVoice.transform.Translate(Vector3.left * 0.07f);
            yield return new WaitForSeconds(0.01f);
        }

    }

    private void Update()
    {
        switch (currentLevel)
        {
            case 1:
                {
                    if (playerInventory != null)
                    {
                        if (playerInventory.Container.Count == 3)
                        {
                            //can Load to next level
                            bedTrigger.SetActive(true);
                            var dialogueManager = FindObjectOfType<DialogueManager>();
                            if (!dialogueFinished)
                            {
                                string[] sentences = { "YOU: I guess it's time to sleep..", "YOU: I must be still dreaming.." };
                                int index = 0;
                                dialogueManager.GetSpeechData(sentences, index);
                                dialogueManager.Run();
                                dialogueFinished = true;
                            }
                        }
                    }
                    break;
                }
            case 2:
                {
                    if (!dialogueFinished2)
                    {
                        string[] sentences = { "YOU: ???", "YOU: What was that..?" };
                        int index = 0;
                        var dialogueManager = FindObjectOfType<DialogueManager>();
                        dialogueManager.GetSpeechData(sentences, index);
                        dialogueManager.Run();
                        dialogueFinished2 = true;
                        canLoadToNextLevel = true;
                    }
                    break;
                }
            case 3:
                {
                    var dialogueManager = FindObjectOfType<DialogueManager>();
                    if (!dialogueFinished3)
                    {
                        string[] sentences = { "MOTHER: You're finally awake.", "MOTHER: Go have breakfast now.", "MOTHER: There's bread on the counter." };
                        int index = 0;
                        dialogueManager.GetSpeechData(sentences, index);
                        dialogueManager.Run();
                        dialogueFinished3 = true;
                    }
                    break;
                }
            case 4:
                {
                    var dialogueManager = FindObjectOfType<DialogueManager>();
                    if (!dialogueFinished4)
                    {
                        string[] sentences = { "FATHER: You're going to school now honey?", "FATHER: ....", "FATHER: Well you can have this bonnet now honey, it's yours now." };
                        int index = 0;
                        dialogueManager.GetSpeechData(sentences, index);
                        dialogueManager.Run();
                        dialogueFinished4 = true;
                        canLoadToNextLevel = true;
                        var item = fatherSprite.gameObject.GetComponent<Item>();
                        playerInventory.AddItem(item.itemInfo, 1);
                    }
                    break;
                }
            case 5: 
            case 6:
            case 7:
                {
                    break;
                }
            case 8:
                {
                    canLoadToNextLevel = true;
                    break;
                }
            case 9:
                {
                    var dialogueManager = FindObjectOfType<DialogueManager>();
                    if (!dialogueFinished9)
                    {
                        string[] sentences = { "MR.GILBERT: How are you feeling?",
                                           "MR.GILBERT: Some of the students saw you passed out, and they said you are running like terrified.",
                                           "MR.GILBERT: I am giving you some medicine.",
                                           "MR.GILBERT: And I am sending you home for now."};
                        int index = 0;
                        dialogueManager.GetSpeechData(sentences, index);
                        dialogueManager.Run();
                        dialogueFinished9 = true;
                    }
                    break;
                }
            case 10:
                {
                    break;
                }
            case 11:
                {
                    break;
                }
            case 12:
                {
                    var dialogueManager = FindObjectOfType<DialogueManager>();
                    bool alreadyLoaded = false;
                    if (dialogueFinished12)
                    {
                        if (!dialogueManager.dialogueActive)
                        {
                            if (!alreadyLoaded)
                            {
                                LoadToNextLevel();
                                alreadyLoaded = true;
                            }
                        }
                    }
                    break;
                }
            case 13:
                {
                    var dialogueManager = FindObjectOfType<DialogueManager>();
                    var player = FindObjectOfType<PlayerMovement>();
                    player.enabled = false;
                    if (!dialogueFinished13)
                    {
                        string[] sentences = { "MOTHER: Your home now.",
                                               "MOTHER: The school called and I was worried.",
                                               "MOTHER: ...And who were you talking to...?",
                                               "MOTHER: ... And is that your father's bonnet...?",
                                               "MOTHER: ...That was buried with him in his grave years ago..."};
                        int index = 0;
                        dialogueManager.GetSpeechData(sentences, index);
                        dialogueManager.Run();
                        dialogueFinished13 = true;
                        canLoadToNextLevel = true;
                    }

                    bool alreadyLoaded = false;

                    if (dialogueFinished13)
                    {
                        if (!dialogueManager.dialogueActive)
                        {
                            if (!alreadyLoaded)
                            {
                                LoadToNextLevel();
                                alreadyLoaded = true;
                            }
                        }
                    }

                    break;
                }
            case 14:
                {
                    var dialogueManager = FindObjectOfType<DialogueManager>();
                    if (!dialogueFinished14)
                    {
                        if(PlayerPrefs.GetString("dialogueDone14") != "Done")
                        {
                            string[] sentences = { "YOU: What does she mean...", "SHADOW: I don't... know..", "SHADOW: But I do know... that thing is still out there... so be careful", "YOU: I need to know what really happened..." };
                            int index = 0;
                            dialogueManager.GetSpeechData(sentences, index);
                            dialogueManager.Run();
                            dialogueFinished14 = true;
                            canLoadToNextLevel = true;
                            PlayerPrefs.SetString("dialogueDone14", "Done");
                            PlayerPrefs.Save();
                        }
                        else
                        {
                            canLoadToNextLevel = true;
                        }
                        
                    }
                    break;
                }
            case 21:
                {
                    canLoadToNextLevel = true;
                    break;
                }
            case 22:
                {
                    var dialogueManager = FindObjectOfType<DialogueManager>();
                    if (!dialogueFinished15)
                    {
                        if(PlayerPrefs.GetString("dialogueDone15") != "Done")
                        {
                            string[] sentences = { "MOTHER: Honey... ", "MOTHER: Do you really miss your father that much?...", "MOTHER: I know it's hard to move on...", "MOTHER: But at least, return his bonnet to him..", "YOU: I'll...", "YOU: Okay..." };
                            int index = 0;
                            dialogueManager.GetSpeechData(sentences, index);
                            dialogueManager.Run();
                            dialogueFinished15 = true;
                            canLoadToNextLevel = true;
                            PlayerPrefs.SetString("dialogueDone15", "Done");
                        }
                        else
                        {
                            canLoadToNextLevel = true;
                        }
                        
                    }
                    break;
                }
            case 16:
                {
                    var dialogueManager = FindObjectOfType<DialogueManager>();
                    if (!dialogueFinished16)
                    {
                        string[] sentences = {"SHADOW: I see you already found them...", "YOU: I don't understand any of this at all... Who are you really...?", 
                                              "SHADOW: ...", "SHADOW: It's time I told you something..", "YOU: Huh..? What is it?", "SHADOW: Wait, what was that..?",
                                              "!!!!!!!", "???: I am Prime Evil..", "PRIME EVIL: A very late introduction...", "PRIME EVIL: But I've come for what's due...",
                                              "PRIME EVIL: Your soul...."};
                        int index = 0;
                        dialogueManager.GetSpeechData(sentences, index);
                        dialogueManager.Run();
                        dialogueFinished16 = true;
                        canLoadToNextLevel = true;
                    }

                    bool alreadyLoaded = false;

                    if (dialogueFinished16)
                    {
                        if (!dialogueManager.dialogueActive)
                        {
                            if (!alreadyLoaded)
                            {
                                LoadToNextLevel();
                                alreadyLoaded = true;
                            }
                        }
                    }

                    bool alreadySpawned = false;

                    if(dialogueManager._index == 6)
                    {
                        if (!alreadySpawned)
                        {
                            var Player = FindObjectOfType<PlayerMovement>();
                            Player.gameObject.GetComponent<SpriteRenderer>().flipX = true;
                            Enemy.SetActive(true);
                            alreadySpawned = true;
                        }
                    }
                    break;
                }
            case 23:
                {
                    var dialogueManager = FindObjectOfType<DialogueManager>();
                    if (!dialogueFinished16)
                    {
                        string[] sentences = {"YOU: Where.... am I?", "YOU: I need to get out of here..."};
                        int index = 0;
                        dialogueManager.GetSpeechData(sentences, index);
                        dialogueManager.Run();
                        dialogueFinished16 = true;
                        canLoadToNextLevel = true;
                    }
                    break;
                }
            case 24:
                {
                    var dialogueManager = FindObjectOfType<DialogueManager>();
                    if (dialogueFinishedF)
                    {
                        if (!dialogueManager.dialogueActive)
                        {
                            StartCoroutine(loadSpecificLevel("Level16"));
                        }
                    }
                    break;
                }
        }
    }

    public void RestartScene()
    {
        StartCoroutine(instantDeath());
    }

    IEnumerator instantDeath()
    {
        instantDeathScreen.SetActive(true);
        var save = FindObjectOfType<AutoSave>();
        save.SaveData();
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadToNextLevel()
    {
        if (canLoadToNextLevel)
        {
            StartCoroutine(_LoadToNextLevel());
        }
    }
    IEnumerator _LoadToNextLevel()
    {
        fadeAnim.SetTrigger("FadeOut");
        var save = FindObjectOfType<AutoSave>();
        save.SaveData();
        switch (currentLevel)
        {
            case 8:
                {
                    Enemy.SetActive(false);
                    break;
                }
        }
        yield return new WaitForSeconds(3f);
        switch (currentLevel)
        {
            case 16:
                {
                    SceneManager.LoadScene("OutroScene");
                    break;
                }
            default:
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                    break;
                }
        }
    }

    public IEnumerator loadSpecificLevel(string sceneName)
    {
        fadeAnim.SetTrigger("FadeOut");
        var save = FindObjectOfType<AutoSave>();
        save.SaveData();
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(sceneName);
    }
}