using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerMovement : MonoBehaviour
{
    public float speed = 0.0001f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float translation_vert = Input.GetAxis("Vertical") * speed;
        float translation_horiz = Input.GetAxis("Horizontal") * speed;
        translation_vert *= Time.deltaTime;
        translation_horiz *= Time.deltaTime;
        transform.Translate(translation_horiz, translation_vert, 0);
    }
}
