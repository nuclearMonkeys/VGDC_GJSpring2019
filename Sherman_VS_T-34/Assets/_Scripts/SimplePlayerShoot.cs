﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject bulletSpawnPoint;
    public bool can_shoot = true;
    public float timeLeft = 1.0f;
    public float time_scale = 1.0f;
    public string player = "1";
    public int damagePerBullet = 0;

    void Start()
    {
        
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        
        if (timeLeft <= 0)
        {
            can_shoot = true;           
        }
        else
        {
            can_shoot = false;
        }
        if ((Input.GetAxis("Fire"+player) != 0 ||Input.GetKeyDown("space")) && can_shoot)
        {
            
            Shoot();
            timeLeft = time_scale;
        }
    }

    void Shoot()
    {

        Quaternion parent_rotation = GetComponentInParent<Transform>().rotation;
        //Vector3 p_rot = parent_rotation.eulerAngles;
        
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, parent_rotation);
        Vector3 localUp = transform.TransformDirection(Vector3.up);
        bullet.GetComponent<Rigidbody2D>().velocity = localUp * 20; 
        bullet.transform.rotation = parent_rotation;
        bullet.GetComponent<AbstractBullet>().damage = damagePerBullet;
    }
}