using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level4_LoadToNext : MonoBehaviour
{
    GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(gameManager.canLoadToNextLevel)
            {
                gameManager.LoadToNextLevel();
            }
        }
    }
}