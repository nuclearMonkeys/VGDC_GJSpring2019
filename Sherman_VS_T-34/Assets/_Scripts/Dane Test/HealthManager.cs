using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoSingleton<HealthManager>
{
    public Transform bar;
    public float currentHealth = 1f;
    public GameObject enemyVars;
    public string string1 = "Player 1 wins: 0";
    public string string2 = "Player 2 wins: 0";
    public int player1_x = 0;
    public int player2_x = 0;
    public int size = 35;
    void OnGUI()
    {
        // Make a text field that modifies stringToEdit.
        player1_x = Screen.width / 16;
        player2_x = Screen.width / 2;
        string1 = "Player 1 wins: " + GameManager.Instance.numOfShermanWins; //Screen.height
        string2 = "Player 2 wins: " + GameManager.Instance.numOfTWins;
        string1 = GUI.TextField(new Rect(player1_x, 10, 200, 20), string1, size);
        string2 = GUI.TextField(new Rect(player2_x, 10, 200, 20), string2, size);
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
}
