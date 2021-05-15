using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int health;
    public int numOfHearts;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public Animator anim;


    private void FixedUpdate()
    {
        if (health == 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
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
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

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
