using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;

    private float timer;
    private int count = 0; 

    // Update is called once per frame
    void Update()
    {
        // float distance = Vector2.Distance(transform.position, player.transform.position);
        // Debug.Log(distance);
        timer += Time.deltaTime;
        if (timer > 1 && count != 1)
        {
            timer = 0;
            shoot();
        }
    }

    void shoot()
    {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
        count = 1; 
    }
}
