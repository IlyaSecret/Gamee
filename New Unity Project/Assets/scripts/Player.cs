using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public bool IJ;
    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    private void FixedUpdate()
    {
        if (health > numOfHearts)
            health = numOfHearts;

        for (var i = 0; i < hearts.Length; i++)
        {
            if (i < health)
                hearts[i].sprite = fullHeart;
            else hearts[i].sprite = emptyHeart;

            if (i < numOfHearts)
                hearts[i].enabled = true;
            else hearts[i].enabled = false;
        }
    }

    void Start()
    {
        IJ = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && IJ == false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 10, 0);
            IJ = true;
        }
    }

    void OnCollisionEnter2D(Collision2D Coll)
    {
        if (Coll.collider.CompareTag("Enemy"))
        {
            Destroy(Coll.gameObject);
            health -= 1;
        }
    }
}
