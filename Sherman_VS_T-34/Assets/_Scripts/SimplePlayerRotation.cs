using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerRotation : MonoBehaviour
{
    private Vector3 lookAt;
    // Start is called before the first frame update
    void Start()
    {  
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }

    void Rotate() {
        lookAt = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        float angleRad = Mathf.Atan2(lookAt.y - this.transform.position.y, lookAt.x - this.transform.position.x);

        float angleDeg = (180 / Mathf.PI) * angleRad;

        this.transform.rotation = Quaternion.Euler(0,0,angleDeg);
        Debug.Log(Input.GetAxis("Mouse X"));
    }
}
