using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalLevelLoad : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            StartCoroutine(gameManager.loadSpecificLevel("FinalBridge"));
        }
    }
}