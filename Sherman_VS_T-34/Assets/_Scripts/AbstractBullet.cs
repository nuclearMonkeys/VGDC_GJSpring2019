using UnityEngine;

public class AbstractBullet : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public int damage = 10;
    public float timeLeft;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        Destroy(gameObject, timeLeft);
    }

    void Update()
    {
        rb.velocity = Vector2.up * speed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("PlayerOne"))
        {
            GameManager.Instance.numOfTWins++;
            other.gameObject.GetComponent<PlayerHealth>().currentHealth -= 10;
        }
        if (other.gameObject.CompareTag("PlayerTwo"))
        {
            GameManager.Instance.numOfShermanWins++;
            other.gameObject.GetComponent<PlayerHealth>().currentHealth -= 10;
        }
    }
}