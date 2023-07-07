using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public float minEnemyInstantateValue;
    public float maxEnemyInstantateValue;
    public float enemyDestroyTime = 5f;
    public Player player;

    private void Start()
    {
        // First object spawn 1s after Start() is called
        // After that, other spawn objects are generated every 2 seconds
        InvokeRepeating("InstantiateEnemy", 1f, 2f);
    }

    void InstantiateEnemy()
    {
        if (player.health > 0)
        {
            // -8.99f, 6.7f
            int randomEnemyPrefab = Random.Range(0, enemyPrefab.Length);
            Vector3 enemyPos = new Vector3(Random.Range(minEnemyInstantateValue, maxEnemyInstantateValue), 3f);
            GameObject enemy = Instantiate(enemyPrefab[randomEnemyPrefab], enemyPos, Quaternion.Euler(0f, 0f, 180f));
            Destroy(enemy, enemyDestroyTime);
        }
        else
        {
            Invoke("DisableGameManager", 3f);
        }
    }

    void DisableGameManager()
    {
        enabled = false;
    }
}
