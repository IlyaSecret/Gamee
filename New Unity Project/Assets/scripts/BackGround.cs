using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    private float width;
    [SerializeField] private Transform background1;
    [SerializeField] private Transform background2;
    [SerializeField] private SpriteRenderer background;

    private void Start()
    {
        width = background.bounds.size.x;      
    }

    private void Update()
    {
        if (background1.position.x + width <= Camera.main.transform.position.x)
        {
            background1.position += new Vector3(2 * width, 0);
        }
        if (background2.position.x + width <= Camera.main.transform.position.x)
        {
            background2.position += new Vector3(2 * width, 0);
        }
    }
}
