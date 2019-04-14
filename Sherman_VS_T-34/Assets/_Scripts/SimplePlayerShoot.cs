using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject bulletSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1)) {
            Shoot();
        }
    }

    void Shoot() {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);
        //float angle = Mathf.Atan2(bullet.transform.position.y, bullet.transform.position.x) * Mathf.Rad2Deg;
        //print(transform.rotation);
        Vector3 localUp = transform.TransformDirection(Vector3.up);
        bullet.GetComponent<Rigidbody2D>().velocity = localUp * 20;
    }

}
