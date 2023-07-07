using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 100; 
    public Rigidbody2D rb;
    public GameObject explosionEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed; 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Asteroid asteroid = collision.GetComponent<Asteroid>(); 
        if (asteroid != null)
        {
            asteroid.TakeDamage(damage);
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
        }

        Destroy(gameObject);
         
        // Debug.Log(collision.name);
    }
}
