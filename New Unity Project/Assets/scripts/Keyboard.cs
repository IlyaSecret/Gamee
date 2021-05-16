
using System;
using UnityEngine.UI;
using UnityEngine;
using Random = UnityEngine.Random;

public class Keyboard : MonoBehaviour
{
    public GameObject Bullet;
    public Transform shotPoint;
    [SerializeField] private Text[] letters;
    private KeyCode[] keyCodes = new KeyCode[9];
    private readonly KeyCode[] dictionary = {KeyCode.O, KeyCode.A};
    public Text hitCount;
    public Text missCount;
    public int miss = 0;
    public int hit = 0;

    private void Awake()
    {
        letters[0].text = "";
        for (var i = 1; i < letters.Length; i++)
        {
            keyCodes[i] = dictionary[Random.Range(0, dictionary.Length)];
            letters[i].text = keyCodes[i].ToString();
        }
    }

    private void Update()
    {
        if (!Input.anyKeyDown) return;
        var pressed = false;
        foreach (var keyCode in dictionary)
        {
            if (Input.GetKeyDown(keyCode) && keyCodes[1] == keyCode)
            {
                pressed = true;
                Instantiate(Bullet, shotPoint.position, transform.rotation);
                Shift();
                hit += 1;
                hitCount.text = hit.ToString();
            }
            
        }

        if (!pressed)
        {
            miss += 1;
            missCount.text = miss.ToString();
        }
    }

    private void Shift()
    {
        for (int i = 0; i < keyCodes.Length - 1; i++)
        {
            keyCodes[i] = keyCodes[i + 1];
            letters[i].text = letters[i + 1].text;

            keyCodes[keyCodes.Length - 1] = dictionary[Random.Range(0, dictionary.Length)];
            letters[keyCodes.Length - 1].text = keyCodes[keyCodes.Length - 1].ToString();
        }


    }
}
