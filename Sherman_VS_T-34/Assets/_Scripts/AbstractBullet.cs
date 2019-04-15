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
}