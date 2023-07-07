using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnAsteroid : MonoBehaviour
{
    public GameObject[] asteroidPrefab;
    public float minAsteroidInstantateValue;
    public float maxAsteroidInstantateValue;
    public float asteroidDestroyTime = 5f;
    public float spawnInterval = 3f; // Interval between asteroid spawns in seconds

    private float timer; // Timer to track elapsed time
    private bool checkSpawned; // Flag to indicate if an asteroid has already been spawned

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval && !checkSpawned)
        {
            // -5.47, 4.26
            int randomAsteroidPrefab = Random.Range(0, asteroidPrefab.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(minAsteroidInstantateValue, maxAsteroidInstantateValue), 1.01f);
            Instantiate(asteroidPrefab[randomAsteroidPrefab], randomSpawnPosition, Quaternion.identity);
            checkSpawned = true;
            timer = 0f; // Reset the timer
        }

        if (timer >= spawnInterval && checkSpawned)
        {
            checkSpawned = false; // Reset the checkSpawned flag
        }
    }
}
