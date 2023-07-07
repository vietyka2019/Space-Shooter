using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public int health = 100;
    public float speed; 

    public GameObject explosionEffect;

    public void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }


    public void TakeDamage(int damage)
    {
        health -= damage; 

        if (health <= 0)
        {
            Die(); 
        }
    }

    void Die()
    {
        Destroy(gameObject);
        // Instantiate(explosionEffect, transform.position, Quaternion.identity);
    }
}
