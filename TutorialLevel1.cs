using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialLevel1 : MonoBehaviour
{
    public GameObject TutorialManager;
    public GameObject continueButton;
    public GameObject Tutorial1, Tutorial2, Tutorial3;
    private int index;
    private bool next = false;
    PlayerMovement player;

    private void Start()
    {
        TutorialManager.SetActive(true);
        player = FindObjectOfType<PlayerMovement>();
        player.enabled = false;
        StartCoroutine(delay());
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (next)
            {
                switch (index)
                {
                    case 0:
                        {
                            next = false;
                            Tutorial1.SetActive(false);
                            Tutorial2.SetActive(true);
                            StartCoroutine(delay());
                            index++;
                            continueButton.SetActive(false);
                            break;
                        }
                    case 1:
                        {
                            next = false;
                            Tutorial2.SetActive(false);
                            Tutorial3.SetActive(true);
                            StartCoroutine(delay());
                            index++;
                            continueButton.SetActive(false);
                            break;
                        }
                    case 2:
                        {
                            next = false;
                            finish();
                            break;
                        }
                }
            }
        }
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(1.5f);
        next = true;
        continueButton.SetActive(true);
    }

    void finish()
    {
        player.enabled = true;
        TutorialManager.SetActive(false);
        Destroy(this);
    }
}