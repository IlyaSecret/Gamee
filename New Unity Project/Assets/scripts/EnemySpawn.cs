using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float padding;
    [SerializeField] private Vector2 enemyPadding;
    [SerializeField] private int maxEnemies;
    private float lastX;

    private void Update()
    {
        if (transform.position.x - lastX >= padding)
        {
            var amount = Random.Range(1, maxEnemies);
            for (var i = 0; i < amount; i++)
            {
                Instantiate(enemyPrefab, new Vector3(transform.position.x + padding + i * Random.Range(enemyPadding.x, enemyPadding.y), transform.position.y - 1), Quaternion.identity);
            }
            lastX = transform.position.x;
        }
    }
}
