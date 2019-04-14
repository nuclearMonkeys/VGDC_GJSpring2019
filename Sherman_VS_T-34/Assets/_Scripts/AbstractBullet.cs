using UnityEngine;

public class AbstractBullet : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public int damage;
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
        PlayerHealth otherPHP = other.gameObject.GetComponent<PlayerHealth>();

        if (other.gameObject.CompareTag("PlayerOne"))
        {
            GameManager.Instance.numOfTWins++;
        }
        else if (other.gameObject.CompareTag("PlayerTwo"))
        {
            GameManager.Instance.numOfShermanWins++;
        }

        if (other != null)
        {
            otherPHP.currentHealth -= damage;
        }
    }
}