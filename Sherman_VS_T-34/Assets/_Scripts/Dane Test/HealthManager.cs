using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public Transform bar;
    public PlayerHealth hp;
    public float currentHealth = 100f;

    void Update()
    {
        Vector3 m_scale = bar.localScale;
        m_scale = new Vector3(currentHealth, m_scale.y, m_scale.z);
        bar.localScale = m_scale;

        if (currentHealth <= 0)
        {
            
            if (currentHealth > 0)
            {
                
                float damage = (1 / (10 * currentHealth + 1));

                currentHealth -= damage;
                
            }
            if (currentHealth <= 0 && (tag == "PlayerOne"))
            {
                GameManager.Instance.numOfTWins++;
                currentHealth = 0f;
                Debug.Log(GameManager.Instance.numOfTWins++);
            }
            if (currentHealth <= 0 && (tag == "PlayerTwo"))
            {
                GameManager.Instance.numOfShermanWins++;
                currentHealth = 0f;
                Debug.Log(GameManager.Instance.numOfShermanWins++);
            }
        }
    }

    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.CompareTag("Bullet"))
    //    {
    //        if (currentHealth > 0)
    //        {
    //            currentHealth -= .1f;
    //        }
    //    }
    //}
}
