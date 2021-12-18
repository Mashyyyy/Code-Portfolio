using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class OutroScene : MonoBehaviour
{
    public Animator fadeAnim;
    //public Text textDisplayer;
    public TextMeshProUGUI textDisplayer;
    [SerializeField]
    private float typeSpeed;
    public string[] sentences;
    public GameObject continueButton;
    private int index;
    private bool canInteract;

    public List<GameObject> cutscenes;

    private void Start()
    {
        StartCoroutine(CutsceneControl());
    }

    private void Update()
    {
        if (textDisplayer.text == sentences[index])
        {
            continueButton.SetActive(true);
            canInteract = true;
        }


        switch (index)
        {
            case 0:
            case 1:
                {
                    cutscenes[0].SetActive(true);
                    break;
                }
            case 2:
            case 3:
                {
                    cutscenes[0].SetActive(false);
                    cutscenes[1].SetActive(true);
                    break;
                }
            case 4:
            case 5:
            case 6:
                {
                    cutscenes[1].SetActive(false);
                    cutscenes[2].SetActive(true);
                    break;
                }
            case 7:
            case 8:
            case 9:
                {
                    cutscenes[2].SetActive(false);
                    cutscenes[3].SetActive(true);
                    break;
                }
            case 10:
            case 11:
                {
                    cutscenes[3].SetActive(false);
                    cutscenes[4].SetActive(true);
                    break;
                }
        }
        NextSentence();
    }

    IEnumerator CutsceneControl()
    {
        fadeAnim.SetTrigger("FadeIn");
        yield return new WaitForSeconds(1f);
        StartCoroutine(displayText());
    }

    IEnumerator displayText()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplayer.text += letter;
            yield return new WaitForSeconds(typeSpeed);
        }
    }

    public void NextSentence()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canInteract)
            {
                continueButton.SetActive(false);
                canInteract = false;

                if (index < sentences.Length - 1)
                {
                    index++;
                    textDisplayer.text = "";
                    StartCoroutine(displayText());
                }
                else
                {
                    textDisplayer.text = "";
                    canInteract = false;
                    StartCoroutine(ExitScene());
                }
            }
        }

    }

    IEnumerator ExitScene()
    {
        fadeAnim.SetTrigger("FadeOut");
        continueButton.gameObject.SetActive(false);
        yield return new WaitForSeconds(4f);
        var autoSave = FindObjectOfType<AutoSave>();
        autoSave.LastSave();
        SceneManager.LoadScene("MainMenu");
    }
}