using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueUnique_Level1 : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject Tutorial1, Tutorial2;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Enemy.SetActive(true);
            Tutorial1.SetActive(false);
            Tutorial2.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}