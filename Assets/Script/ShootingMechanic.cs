using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingMechanic : MonoBehaviour
{
    public Transform firePoint; // always stay infront of the main spaceship and follow it  
    public GameObject bulletPrefab; 
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();    
        } 
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);  // (original, position, rotation)
    }
}
