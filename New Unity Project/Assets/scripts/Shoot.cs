using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject Bullet;
    public Transform shotPoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            Instantiate(Bullet, shotPoint.position, transform.rotation);
    }
}
