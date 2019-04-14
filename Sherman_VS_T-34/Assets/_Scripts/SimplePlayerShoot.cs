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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
        if (Input.GetKeyDown(fire_key) && can_shoot) {
            Shoot();
            timeLeft = time_scale;
        }
    }

    void Shoot() {
        Quaternion parent_rotation = this.GetComponentInParent<Transform>().rotation;
        Vector3 p_rot = parent_rotation.ToEulerAngles();
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, parent_rotation);
        Destroy(bullet, 2f);
        //float angle = Mathf.Atan2(bullet.transform.position.y, bullet.transform.position.x) * Mathf.Rad2Deg;
        //print(transform.rotation);
        Vector3 localUp = transform.TransformDirection(Vector3.up);
        bullet.GetComponent<Rigidbody2D>().velocity = localUp * 20;
        
        //Debug.Log(parent_rotation);
        bullet.transform.rotation = parent_rotation;
        //GetComponentInParent
    }

}