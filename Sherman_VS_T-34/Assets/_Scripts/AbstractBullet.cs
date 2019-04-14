using UnityEngine;

public class AbstractBullet : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public int damage = 10;
    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.up * speed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("PlayerOne")) {
            other.gameObject.GetComponent<SimplePlayerMovement>().gameManager.numOfTWins++;
            gameManager = other.gameObject.GetComponent<SimplePlayerMovement>().gameManager;
            other.gameObject.GetComponent<PlayerHealth>().currentHealth -= 10;
            //Destroy(other.gameObject);
            //Destroy(this);
            //gameManager.StartGame();
        }
        if (other.gameObject.CompareTag("PlayerTwo")) {
            other.gameObject.GetComponent<PlayerMovement2>().gameManager.numOfShermanWins++;
            gameManager = other.gameObject.GetComponent<PlayerMovement2>().gameManager;
            other.gameObject.GetComponent<PlayerHealth>().currentHealth -= 10;
            //Destroy(other.gameObject);
            //Destroy(this);
            //gameManager.StartGame();
        }


    }
}
