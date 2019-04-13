using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour
{
    private static MonoSingleton<T> instance;
    public static MonoSingleton<T> Instance { get { return instance; } set { instance = value; } }

    private void Awake()
    {
        
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}