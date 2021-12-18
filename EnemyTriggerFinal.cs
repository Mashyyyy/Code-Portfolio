using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTriggerFinal : MonoBehaviour
{
    public GameObject enemy;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            enemy.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}