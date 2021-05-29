
using System;
using System.Linq;
using UnityEngine.UI;
using UnityEngine;
using Random = UnityEngine.Random;
using System.Collections.Generic;

public class Keyboard : MonoBehaviour
{
    public GameObject Bullet;
    public Transform shotPoint;
    [SerializeField] private Text[] letters;
    private KeyCode[] keyCodes = new KeyCode[9];
    private KeyCode[] dictionaryKeyCodes;
    [SerializeField] private Color[] colors;
    public Text hitCount;
    public Text missCount;
    public int miss = 0;
    public int hit = 0;
    public Animator playerAnim;

    private readonly Dictionary<KeyCode, string> dictionary = new Dictionary<KeyCode, string>
    {
        [KeyCode.Q] = "É",
        [KeyCode.W] = "Ö",
        [KeyCode.E] = "Ó",
        [KeyCode.R] = "Ê",
        [KeyCode.T] = "Å",
        [KeyCode.Y] = "Í",
        [KeyCode.U] = "Ã",
        [KeyCode.I] = "Ø",
        [KeyCode.O] = "Ù",
        [KeyCode.P] = "Ç",
        [KeyCode.LeftBracket] = "Õ",
        [KeyCode.RightBracket] = "Ú",
        [KeyCode.A] = "Ô",
        [KeyCode.S] = "Û",
        [KeyCode.D] = "Â",
        [KeyCode.F] = "À",
        [KeyCode.G] = "Ï",
        [KeyCode.H] = "Ð",
        [KeyCode.J] = "Î",
        [KeyCode.K] = "Ë",
        [KeyCode.L] = "Ä",
        [KeyCode.Semicolon] = "Æ",
        [KeyCode.Quote] = "Ý",
        [KeyCode.Z] = "ß",
        [KeyCode.X] = "×",
        [KeyCode.C] = "Ñ",
        [KeyCode.V] = "Ì",
        [KeyCode.B] = "È",
        [KeyCode.N] = "Ò",
        [KeyCode.M] = "Ü",
        [KeyCode.Comma] = "Á",
        [KeyCode.Period] = "Þ"
    };

    private void Awake()
    {
        dictionaryKeyCodes = dictionary.Keys.ToArray();
        letters[0].text = "";
        for (var i = 0; i < letters.Length; i++)
        {
            keyCodes[i] = dictionaryKeyCodes[Random.Range(0, dictionaryKeyCodes.Length)];
            letters[i].text = dictionary[keyCodes[i]];
            letters[i].color = colors[Random.Range(0, colors.Length)];
        }
    }

    private void Update()
    {
        if (!Input.anyKeyDown)
        {
            return;
        }
        if (!dictionary.Keys.Any(keyCode => Input.GetKeyDown(keyCode) && keyCodes[1] == keyCode))
        {
            miss += 1;
            missCount.text = miss.ToString();
            return;
        }
        playerAnim.SetTrigger("Shoot");
        Instantiate(Bullet, shotPoint.position, transform.rotation);
        hit += 1;
        hitCount.text = hit.ToString();
        Shift();
    }

    private void Shift()
    {
        for (var i = 0; i < keyCodes.Length - 1; i++)
        {
            keyCodes[i] = keyCodes[i + 1];
            letters[i].text = letters[i + 1].text;
            letters[i].color = letters[i + 1].color;
        }
        keyCodes[keyCodes.Length - 1] = dictionaryKeyCodes[Random.Range(0, dictionaryKeyCodes.Length)];
        letters[keyCodes.Length - 1].text = dictionary[keyCodes[keyCodes.Length - 1]];
        letters[keyCodes.Length - 1].color = colors[Random.Range(0, colors.Length)];
    }
}
