using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_char_mvmt : MonoBehaviour
{
    public float speed = 10.0f;
    public Rigidbody2D rb;
    public string player = "0";
    public float angle = 0.0f;
    public bool isSprite = false;
    public float rotateSpeed = 1f;

    public void Update()
    {
        float translation_horiz = Input.GetAxis("LHor" + player) * speed;
        float translation_vert = Input.GetAxis("LVert" + player) * speed;

        rb.velocity = new Vector3(translation_horiz, translation_vert);
        if (isSprite)
        {
            if (Input.GetAxis("LHor" + player) != 0 || Input.GetAxis("LVert" + player) != 0)
            {
                angle = Mathf.Atan2(Input.GetAxis("LHor" + player), Input.GetAxis("LVert" + player)) * 180 / Mathf.PI;
            }

            Vector3 rotationVector = new Vector3(0, 0, angle*rotateSpeed);
            Quaternion rotation = Quaternion.Euler(rotationVector);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, .1f);
        }
    }
}
