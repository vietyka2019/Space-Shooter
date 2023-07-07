using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Image healthBar;
    public float maxHealth = 100;
    public float health;
    
    public GameObject explosionEffect;

    public GameOverScreen gameOverScreen;
    public SpawnEnemySpaceship spawnEnemySpaceship; 

    private void Start()
    {
        health = maxHealth; 
    }

    private void Update()
    {
        //healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);
        // healthBar.fillAmount = health / maxHealth; 
        
    }                           

    public void TakeDamage(int damage)
    {
        
        health -= damage;
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);

        if (health <= 0)
        {
            // health = 0; 
            Die();
            // gameManager.SetActive(false);
            gameOverScreen.Setup();
            // spawnEnemySpaceship.SetActive(false); 


        }
    }

    public void Die()
    {
        Instantiate(explosionEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}