using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private Transform bar;
    // Start is called before the first frame update
    void Start()
    {
        //Transform bar = Transform.Find("Bar");
        //bar.localScale = new Vector3(0.4f);
    }
    public void SetSize(float sizeNormalized)
    {
        //bar.localScale = new Vector3(sizeNormalized, 1f);
    }
}
