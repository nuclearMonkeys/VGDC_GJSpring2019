using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth = 100;

    public GameObject playerSlider;

    private void Start()
    {
        if (CompareTag("PlayerOne"))
        {
            playerSlider = GameObject.FindGameObjectWithTag("PlayerOneHealth");
        }
        if (CompareTag("PlayerTwo"))
        {
            playerSlider = GameObject.FindGameObjectWithTag("PlayerTwoHealth");
        }
    }

    private void Update()
    {
        playerSlider.GetComponent<Slider>().value = currentHealth;

        if (currentHealth <= 0 )
        {   
            Destroy(gameObject);
        }
    }
}