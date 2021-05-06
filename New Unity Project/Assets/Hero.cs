using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public int health;

    public int damage;

    private Rigidbody2D rb;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.collider.CompareTag("Tile"))
        {
            Destroy(other.gameObject);
        }
        
    }
}
