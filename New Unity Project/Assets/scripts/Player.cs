using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private UnityEvent OnDead;

    public int health;
    public int numOfHearts;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    private float speed = 6f;
    public Animator anim;

    private void FixedUpdate()
    {
        if (Time.timeScale == 0) OnDead.Invoke();
        if (health == 0)
        {
            Time.timeScale = 0f;
            OnDead.Invoke();
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

    void Update()
    {
        speed += Time.deltaTime / 5;
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }

    void OnCollisionEnter2D(Collision2D Coll)
    {
        if (Coll.collider.CompareTag("Enemy"))
        {
            anim.SetTrigger("Hitted");
            health -= 1;
        }
    }
}
