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
        //����� �������
        { "�", new Color(0.04f, 0.89f, 0, 0.98f) },
        { "�", new Color(0.04f, 0.89f, 0, 0.98f) },
        { "�", new Color(0.04f, 0.89f, 0, 0.98f) },
        { "�", new Color(0.04f, 0.89f, 0, 0.98f) },
        { "�", new Color(0.04f, 0.89f, 0, 0.98f) },
        { "�", new Color(0.04f, 0.89f, 0, 0.98f) },
        { "�", new Color(0.04f, 0.89f, 0, 0.98f) },
        { "�", new Color(0.04f, 0.89f, 0, 0.98f) },

        //����� �������
        { "�", new Color(0.18f, 0.82f, 0.98f, 0.98f) },
        { "�", new Color(0.18f, 0.82f, 0.98f, 0.98f) },
        { "�", new Color(0.18f, 0.82f, 0.98f, 0.98f) },
        { "�", new Color(0.18f, 0.82f, 0.98f, 0.98f) },
        { "�", new Color(0.18f, 0.82f, 0.98f, 0.98f) },
        { "�", new Color(0.18f, 0.82f, 0.98f, 0.98f) },

        //����� �������
        { "�", new Color(1.0f, 0.41f, 0.71f) },
        { "�", new Color(1.0f, 0.41f, 0.71f) },
        { "�", new Color(1.0f, 0.41f, 0.71f) },
        { "�", new Color(1.0f, 0.41f, 0.71f) },
        { "�", new Color(1.0f, 0.41f, 0.71f) },
        { "�", new Color(1.0f, 0.41f, 0.71f) },

        //����� ���������
        { "�", new Color(1.0f, 0.64f, 0.0f) },
        { "�", new Color(1.0f, 0.64f, 0.0f) },
        { "�", new Color(1.0f, 0.64f, 0.0f) },
        { "�", new Color(1.0f, 0.64f, 0.0f) },
        { "�", new Color(1.0f, 0.64f, 0.0f) },
        { "�", new Color(1.0f, 0.64f, 0.0f) },

        //����� ������
        { "�", new Color(0.98f, 0.8f, 0.13f, 0.98f) },
        { "�", new Color(0.98f, 0.8f, 0.13f, 0.98f) },
        { "�", new Color(0.98f, 0.8f, 0.13f, 0.98f) },
        { "�", new Color(0.98f, 0.8f, 0.13f, 0.98f) },
        { "�", new Color(0.98f, 0.8f, 0.13f, 0.98f) },
        { "�", new Color(0.98f, 0.8f, 0.13f, 0.98f) },

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
        if (Time.timeScale == 0) return;
        if (!Input.anyKeyDown) return;
        if (Input.GetKey(KeyCode.Escape)) return;
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
