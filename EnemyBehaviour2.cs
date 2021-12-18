using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour2 : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    public AudioClip monsterSFX1, monsterSFX2;
    public AudioSource audioSource;
    private int index = 0;
    private float timeToWait;

    private void Start()
    {
        PlayAudio();
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerMovement>().enabled = false;
            collision.gameObject.GetComponent<AudioSource>().Stop();
            var gameManager = FindObjectOfType<GameManager>();
            gameManager.RestartScene();
        }
    }

    void PlayAudio()
    {
        switch (index)
        {
            case 0:
                {
                    index = 1;
                    timeToWait = 4f;
                    audioSource.clip = monsterSFX1;
                    break;
                }
            case 1:
                {
                    index = 0;
                    timeToWait = 5f;
                    audioSource.clip = monsterSFX2;
                    break;
                }
        }
        audioSource.Play();
        Invoke("PlayAudio", timeToWait);
    }
}