using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    [SerializeField] private HealthBar healthBar;
    public float currentHealth = 1f;

    // Start is called before the first frame update
    void Start()
    {
        healthBar.SetSize(currentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.SetSize(currentHealth);
        //currentHealth -= 0.01f;
    }
}
