using UnityEngine;

public class AbstractBullet : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = Vector2.down * speed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("PlayerOne")) {
            other.gameObject.GetComponent<SimplePlayerMovement>().gameManager.numOfTWins++;
            gameManager = other.gameObject.GetComponent<SimplePlayerMovement>().gameManager;
            //print(other.gameObject.GetComponent<SimplePlayerMovement>().gameManager.numOfTWins);
            Destroy(other.gameObject);
            Destroy(this);
            gameManager.StartGame();
        }
        if (other.gameObject.CompareTag("PlayerTwo")) {
            other.gameObject.GetComponent<PlayerMovement2>().gameManager.numOfShermanWins++;
            gameManager = other.gameObject.GetComponent<PlayerMovement2>().gameManager;
            //print(other.gameObject.GetComponent<PlayerMovement2>().gameManager.numOfShermanWins);
            Destroy(other.gameObject);
            Destroy(this);
            gameManager.StartGame();
        }
        
    }
}
