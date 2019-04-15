using UnityEngine;

public class AbstractBullet : MonoBehaviour
{
    public float damage;
    public float timeLeft;

    private void Start()
    {
        Destroy(gameObject, timeLeft);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Transform otherTrans = collision.transform;

        if (otherTrans.CompareTag("PlayerOne") || otherTrans.CompareTag("PlayerOne"))
        {
            otherTrans.root.GetComponent<HealthManager>().currentHealth = Mathf.Max(0f, otherTrans.root.GetComponent<HealthManager>().currentHealth - damage);
        }
    }
}