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
            GameManager.Instance.numOfTWins++;
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
