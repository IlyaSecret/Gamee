using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScr : MonoBehaviour
{
    public Animator enemyAnim;
    private void OnCollisionEnter2D(Collision2D Coll)
    {
        if (Coll.collider.CompareTag("Bullet"))
        {
            enemyAnim.SetTrigger("Die");
            Destroy(gameObject);
        }
    }
}
