using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTrigger : MonoBehaviour
{
    [HideInInspector]
    public bool isAlreadyActive = false;
    private FinalDoorTrigger finalTrigger;

    private void Start()
    {
        finalTrigger = FindObjectOfType<FinalDoorTrigger>();
    }

    public void Click_Close()
    {
        if (isAlreadyActive)
        {
            isAlreadyActive = false;
            finalTrigger.Reactivate();
        }
    }

    public void Click_School()
    {
        if (isAlreadyActive)
        {
            finalTrigger.loadToLevel("FinalPuzzle1");
        }
    }

    public void Click_LivingRoom()
    {
        if (isAlreadyActive)
        {
            finalTrigger.loadToLevel("FinalPuzzle2");
        }
    }
}