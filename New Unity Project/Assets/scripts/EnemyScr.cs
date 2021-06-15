using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScr : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.collider.CompareTag("Bullet"))
        {
            GetComponent<Animator>().SetTrigger("Die");
            GetComponent<Collider2D>().enabled = false;
        }
        else if (collider.collider.CompareTag("Player"))
        {
            GetComponent<Animator>().SetTrigger("Attack");
            GetComponent<Collider2D>().enabled = false;
        }
    }

    public void Die() => Destroy(gameObject);
}
