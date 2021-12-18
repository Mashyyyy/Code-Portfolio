using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    private Transform target;

    private void Start()
    {
        target = FindObjectOfType<PlayerMovement>().gameObject.transform;
    }

    private void Update()
    {
        float step = moveSpeed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, target.position, step);
        AnimateMove();
    }

    void AnimateMove()
    {
        var anim = GetComponent<Animator>();
        anim.SetTrigger("isWalking");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerMovement>().enabled = false;
            collision.gameObject.GetComponent<AudioSource>().Stop();
            var gameManager = FindObjectOfType<GameManager>();
            gameManager.RestartScene();
        }
    }
}