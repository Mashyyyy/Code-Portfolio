using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Level8 : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip audioToChange;
    public GameObject enemy;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            audio.clip = audioToChange;
            audio.Play();
            enemy.SetActive(true);
        }
    }
}