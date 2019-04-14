using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;

    void Awake()
    {       
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float translation_horiz = 0f;
        float translation_vert = 0f;

        if (tag == "PlayerOne")
        {
            //if (Input.GetKey("a"))
            //{
            //    translation_horiz = -speed * Time.deltaTime;
            //}
            //if (Input.GetKey("d"))
            //{
            //    translation_horiz = speed * Time.deltaTime;
            //}
            //if (Input.GetKey("w"))
            //{
            //    translation_vert = speed * Time.deltaTime;
            //}
            //if (Input.GetKey("s"))
            //{
            //    translation_vert = -speed * Time.deltaTime;
            //}

        }
        else if (tag == "PlayerTwo")
        {
            //if (Input.GetKey("j"))
            //{
            //    translation_horiz = -speed * Time.deltaTime;
            //}
            //if (Input.GetKey("l"))
            //{
            //    translation_horiz = speed * Time.deltaTime;
            //}
            //if (Input.GetKey("i"))
            //{
            //    translation_vert = speed * Time.deltaTime;
            //}
            //if (Input.GetKey("k"))
            //{
            //    translation_vert = -speed * Time.deltaTime;
            //}
        }
        rb.velocity = new Vector3(translation_horiz, translation_vert);
    }
}