using System.Collections;
using System.Collections.Generic;
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
    public GameObject EndGameMenu;
    private float speed = 6f;

    private void FixedUpdate()
    {
        if (health == 0)
        {
            EndGameMenu.SetActive(true);
            Time.timeScale = 0f;
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
    }

    void Update()
    {
        speed += Time.deltaTime / 5;
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
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
