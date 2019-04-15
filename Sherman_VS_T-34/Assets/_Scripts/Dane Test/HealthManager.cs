using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoSingleton<HealthManager>
{
    public Transform bar;
    public float currentHealth = 1f;
    public GameObject enemyVars;

    protected override void OnStart()
    {
        
    }

    void Update()
    {
        if (tag == "PlayerOne")
        {

        }
        Vector3 m_scale = bar.localScale;
        m_scale = new Vector3(currentHealth, m_scale.y, m_scale.z);
        bar.localScale = m_scale;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            if (currentHealth > 0)
            {
                currentHealth -= .1f;
            }
            if (currentHealth <= 0)
            {
                GameManager.Instance.numOfTWins++;
                Debug.Log(GameManager.Instance.numOfTWins++);
            }
        }
    }
}
