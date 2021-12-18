using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialogueScene, inventoryBar;
    [HideInInspector]
    public bool dialogueActive = false;
    private Animator dialogue;
    private PlayerMovement player;

    [SerializeField]
    private float typeSpeed;

    private string[] _sentences;
    public int _index;

    public TextMeshProUGUI textDisplayer;

    private PlayerCamera playerCamera;

    private ObjectiveManager objManager;

    private void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
        playerCamera = FindObjectOfType<PlayerCamera>();
        dialogue = dialogueScene.GetComponent<Animator>();
        objManager = FindObjectOfType<ObjectiveManager>();
    }


    private void Update()
    {
        player.inDialogue = dialogueActive;
        if(_sentences != null)
        {
            if (textDisplayer.text == _sentences[_index])
                if (Input.GetKeyDown(KeyCode.Space))
                    StartCoroutine(NextSentence());
        }
    }

    public void GetSpeechData(string[] sentences, int index)
    {
        _sentences = sentences;
        _index = index;
    }

    public void GetSpeechDataSingle(string[] sentences)
    {
        _sentences = sentences;
        _index = 0;
    }

    public void Run()
    {
        StartCoroutine(startDialogue());
    }

    IEnumerator dialogueType()
    {
        foreach (char letter in _sentences[_index].ToCharArray())
        {
            textDisplayer.text += letter;
            yield return new WaitForSeconds(typeSpeed);
        }
    }

    IEnumerator startDialogue()
    {
        player.GetComponent<Animator>().SetBool("isWalking", false);
        player.rb2d.velocity = Vector2.zero;
        player.audioSource.Stop();
        dialogueScene.SetActive(true);
        inventoryBar.SetActive(false);
        objManager.gameObject.SetActive(false);
        dialogueActive = true;
        var lerpValue = Mathf.SmoothStep(playerCamera.gameObject.GetComponent<Camera>().orthographicSize,
                                   playerCamera.gameObject.GetComponent<Camera>().orthographicSize - 0.5f,
                                   0.5f);
        playerCamera.gameObject.GetComponent<Camera>().orthographicSize = lerpValue;
        yield return new WaitForSeconds(0.45f);
        StartCoroutine(dialogueType());
    }

    IEnumerator endDialogue()
    {
        yield return new WaitForSeconds(1f);
        dialogue.SetTrigger("FadeOut");
        yield return new WaitForSeconds(0.45f);
        dialogueScene.SetActive(false);
        inventoryBar.SetActive(true);
        objManager.gameObject.SetActive(true);

        var lerpValue = Mathf.SmoothStep(playerCamera.gameObject.GetComponent<Camera>().orthographicSize,
                                   playerCamera.gameObject.GetComponent<Camera>().orthographicSize + 0.5f,
                                   0.5f);
        dialogueActive = false;
        playerCamera.gameObject.GetComponent<Camera>().orthographicSize = lerpValue; 
    }

    IEnumerator NextSentence()
    {
        if (_index < _sentences.Length - 1)
        {
            _index++;
            textDisplayer.text = "";
            StartCoroutine(dialogueType());
        }
        else
        {
            textDisplayer.text = "";
            StartCoroutine(endDialogue());
        }
        yield return new WaitForSeconds(0.01f);
    }
}