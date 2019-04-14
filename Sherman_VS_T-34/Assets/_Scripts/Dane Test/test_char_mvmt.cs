using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_char_mvmt : MonoBehaviour
{
    public float speed = 10.0f;
    public Rigidbody2D rb;
    public string player = "0";
    public float angle = 0.0f;
    
    public void Update()
    {
        float translation_horiz = Input.GetAxis("LHor" + player) * speed;
        float translation_vert = Input.GetAxis("LVert" + player) * speed;

        rb.velocity = new Vector3(translation_horiz, translation_vert);
        /*
        if (Input.GetAxis("x_rotate" + player) != 0 || Input.GetAxis("y_rotate" + player) != 0)
        {
            angle = Mathf.Atan2(Input.GetAxis("x_rotate" + player), Input.GetAxis("y_rotate" + player)) * 180 / Mathf.PI;
        }
        
        Vector3 rotationVector = new Vector3(0, 0, angle);
        Quaternion rotation = Quaternion.Euler(rotationVector);
        //transform.rotation = rotation;
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, .1f);*/
    }
}
