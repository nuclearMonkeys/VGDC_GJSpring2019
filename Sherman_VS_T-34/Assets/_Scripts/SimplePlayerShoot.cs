using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
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
        Instantiate(bulletPrefab, this.transform.position, this.transform.rotation);
    }

}
