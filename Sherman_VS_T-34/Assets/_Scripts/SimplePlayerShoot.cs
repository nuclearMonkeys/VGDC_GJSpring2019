using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject bulletSpawnPoint;
    public HealthManager hm;
    public bool can_shoot = true;
    public float timeLeft = 1.0f;
    public float time_scale = 1.0f;
    public string player = "1";
    public float damagePerBullet = 0;

    void Awake()
    {
        hm = transform.root.GetComponent<HealthManager>();
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;

        damagePerBullet = 1 / (10 * hm.currentHealth) + 1;
        
        if (timeLeft <= 0)
        {
            can_shoot = true;           
        }
        else
        {
            can_shoot = false;
        }
        if ((Input.GetAxis("Fire"+player) != 0 || Input.GetKeyDown("space")) && can_shoot)
        {          
            Shoot();
            timeLeft = time_scale;
        }
    }

    void Shoot()
    {
        Quaternion parent_rotation = GetComponentInParent<Transform>().rotation;        
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, parent_rotation);
        Vector3 localUp = transform.TransformDirection(Vector3.up);

        bullet.GetComponent<Rigidbody2D>().velocity = localUp * 20; 
        bullet.transform.rotation = parent_rotation;
        bullet.GetComponent<AbstractBullet>().damage = damagePerBullet;
    }
}