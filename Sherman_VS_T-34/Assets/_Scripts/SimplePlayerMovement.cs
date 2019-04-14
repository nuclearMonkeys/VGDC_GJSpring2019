using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerMovement : MonoBehaviour
{
    public GameManager gameManager;
    public float speed = 10.0f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        //gameManager.playerOne = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        float translation_horiz = 0f;
        float translation_vert = 0f;
        if (Input.GetKey("a"))
        {
            translation_horiz = -speed * Time.deltaTime;
            Debug.Log("Left");
        }
        if (Input.GetKey("d"))
        {
             translation_horiz = speed * Time.deltaTime;
            Debug.Log("Right");
        }
        if (Input.GetKey("w"))
        {
             translation_vert = speed * Time.deltaTime;
            Debug.Log("Up");
        }
        if (Input.GetKey("s"))
        {
             translation_vert = -speed * Time.deltaTime;
            Debug.Log("Down");
        }
        //transform.Translate(translation_horiz, translation_vert, 0);
        rb.velocity = new Vector3(translation_horiz, translation_vert);
        
        
        //string test = Input.GetAxis("Vertical1") + " vertical 1";
        //string[] astrJoysticks = Input.GetJoystickNames();
        //Debug.Log(astrJoysticks);
    }
}
