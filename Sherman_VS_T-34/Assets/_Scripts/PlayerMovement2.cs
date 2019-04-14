using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
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
        gameManager.gameStarted = true;
        //gameManager.playerTwo = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

        float translation_horiz = 0f;
        float translation_vert = 0f;
        if (Input.GetKey("j"))
        {
            translation_horiz = -speed * Time.deltaTime;
            //Debug.Log("Left");
        }
        if (Input.GetKey("l"))
        {
            translation_horiz = speed * Time.deltaTime;
            // Debug.Log("Right");
        }
        if (Input.GetKey("i"))
        {
            translation_vert = speed * Time.deltaTime;
            // Debug.Log("Up");
        }
        if (Input.GetKey("k"))
        {
            translation_vert = -speed * Time.deltaTime;
            //  Debug.Log("Down");
        }


        //transform.Translate(translation_horiz, translation_vert, 0);
        rb.velocity = new Vector3(translation_horiz, translation_vert);
    }
}
