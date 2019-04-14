using UnityEngine;

public class AbstractBullet : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = Vector2.down * speed;
    }
}
