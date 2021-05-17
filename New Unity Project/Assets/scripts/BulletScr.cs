using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScr : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }

    
    void Update()
    {
        //уничтожение пули, если она выйдет за предел экрана
        var min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        var max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        if (transform.position.x > max.x || transform.position.x < min.x)
        {
            Destroy(this.gameObject);
        }
        if (transform.position.y > max.y || transform.position.y < min.y)
        {
            Destroy(this.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D Coll)
    {
        if (Coll.collider.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
