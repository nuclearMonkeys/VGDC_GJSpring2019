using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject bulletSpawnPoint;
    public string fire_key = "space";
    public bool can_shoot = true;
    public float timeLeft = 1.0f;
    public float time_scale = 1.0f;

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
        if (Input.GetKeyDown(fire_key) && can_shoot)
        {
            Shoot();
            timeLeft = time_scale;
        }
    }

    void Shoot()
    {
        Quaternion parent_rotation = GetComponentInParent<Transform>().rotation;
        Vector3 p_rot = parent_rotation.eulerAngles;
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, parent_rotation);
        Vector3 localUp = transform.TransformDirection(Vector3.up);
        bullet.GetComponent<Rigidbody2D>().velocity = localUp * 20; 
        bullet.transform.rotation = parent_rotation;
    }

}