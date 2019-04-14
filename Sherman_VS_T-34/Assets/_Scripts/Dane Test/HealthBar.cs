using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform bar = Transform.Find("Bar");
        bar.localScale = new Vector3(0.4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
