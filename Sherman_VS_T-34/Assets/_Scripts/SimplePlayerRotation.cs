﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SimplePlayerRotation : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    private void Update()
    {
        float horizontal = Input.GetAxis("Mouse X1") * Time.deltaTime * moveSpeed;
        float vertical = Input.GetAxis("Mouse Y1") * Time.deltaTime * moveSpeed;
        float angle = Mathf.Atan2(horizontal, vertical) * Mathf.Rad2Deg;
        Vector3 rotationVector = new Vector3(0, 0,-angle*moveSpeed);
        Quaternion rotation = Quaternion.Euler(rotationVector);
        this.transform.rotation = rotation;
    }
}
