using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_rotate : MonoBehaviour
{
    public string player = "0";
    public float angle = 0.0f;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("x_rotate" + player) != 0 || Input.GetAxis("y_rotate" + player) != 0)
        {
            angle = Mathf.Atan2(Input.GetAxis("x_rotate" + player), Input.GetAxis("y_rotate" + player)) * 180 / Mathf.PI;
        }

        Vector3 rotationVector = new Vector3(0, 0, angle);
        Quaternion rotation = Quaternion.Euler(rotationVector);
        //transform.rotation = rotation;
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, .1f);
    }
}
