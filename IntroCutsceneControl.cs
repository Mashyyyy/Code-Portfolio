using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class IntroCutsceneControl : MonoBehaviour
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

    public GameObject cutscene1, cutscene2, cutscene3_0, cutscene3_1, cutscene3_2, cutscene3_3, cutscene4;

    private void Start()
    {
        StartCoroutine(CutsceneControl());
    }

    private void Update()
    {
        if(textDisplayer.text == sentences[index])
        {
            continueButton.SetActive(true);
            canInteract = true;
        }


        switch (index)
        {
            case 0:
            case 1:
                {
                    cutscene1.SetActive(true);
                    break;
                }
            case 2:
            case 3:
                {
                    cutscene1.SetActive(false);
                    cutscene2.SetActive(true);
                    break;
                }
            case 4:
                {
                    cutscene2.SetActive(false);
                    cutscene3_0.SetActive(true);
                    break;
                }
            case 5:
                {
                    cutscene3_0.SetActive(false);
                    cutscene3_1.SetActive(true);
                    break;
                }
            case 6:
                {
                    cutscene3_1.SetActive(false);
                    cutscene3_2.SetActive(true);
                    break;
                }
            case 7:
                {
                    cutscene3_2.SetActive(false);
                    cutscene3_3.SetActive(true);
                    break;
                }
            case 8:
            case 9:
                {
                    cutscene3_3.SetActive(false);
                    cutscene4.SetActive(true);
                    break;
                }
        }
        NextSentence();
    }

    IEnumerator CutsceneControl()
    {
        yield return new WaitForSeconds(4f);
        fadeAnim.SetTrigger("FadeIn");
        yield return new WaitForSeconds(1f);
        StartCoroutine(displayText());
    }

    IEnumerator displayText()
    {
        foreach(char letter in sentences[index].ToCharArray())
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
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level1");
    }
}