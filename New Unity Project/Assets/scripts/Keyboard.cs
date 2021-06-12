using System.Linq;
using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Events;

public class Keyboard : MonoBehaviour
{
    [SerializeField] private UnityEvent OnCorrectPress;
    [SerializeField] private UnityEvent OnLevelEnd;
    [SerializeField] private UnityEvent OnIncorrectPress;

    public GameObject Bullet;
    public Transform shotPoint;

    [SerializeField] private Text[] letters;
    private Dictionary<string, Color> colors = new Dictionary<string, Color>
    {
        { "É", new Color(255,100,50) },
        { "Ö", new Color(0,0,0) },
        { "Ó", new Color(0,0,0) },
        { "Ê", new Color(0,0,0) },
        { "Å", new Color(0,0,0) },
        { "Í", new Color(0,0,0) },
        { "Ã", new Color(0,0,0) },
        { "Ø", new Color(0,0,0) },
        { "Ù", new Color(0,0,0) },
        { "Ç", new Color(0,0,0) },
        { "Õ", new Color(0,0,0) },
        { "À", new Color(0,0,0) },
        { "Î", new Color(50,50,50) },
    };

    private int neededLettersAmount = LevelCharacteristics.CurrentLevelData.LettersAmount;

    private KeyCode[] keyCodes = new KeyCode[9];
    private KeyCode[] dictionaryKeyCodes;

    public Text hitCount;
    public Text missCount;

    public int miss = 0;
    public int hit = 0;

    public Animator playerAnim;

    private readonly Dictionary<KeyCode, string> dictionary = LevelCharacteristics.CurrentLevelData.Dictionary;

    private void Awake()
    {
        dictionaryKeyCodes = dictionary.Keys.ToArray();
        letters[0].text = "";
        for (var i = 0; i < letters.Length; i++)
        {
            keyCodes[i] = dictionaryKeyCodes[Random.Range(0, dictionaryKeyCodes.Length)];
            letters[i].text = dictionary[keyCodes[i]];
            letters[i].color = colors[letters[i].text];
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
            OnIncorrectPress.Invoke();
            return;
        }
        OnCorrectPress.Invoke();
        playerAnim.SetTrigger("Shoot");
        Instantiate(Bullet, shotPoint.position, transform.rotation);
        hit += 1;
        hitCount.text = hit.ToString();
        Shift();
        if (hit == neededLettersAmount)
        {
            Time.timeScale = 0;
            OnLevelEnd.Invoke();
        }
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
        letters[keyCodes.Length - 1].color = colors[letters[keyCodes.Length - 1].text];
    }
}
