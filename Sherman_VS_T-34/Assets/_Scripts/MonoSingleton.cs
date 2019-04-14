using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
    private static MonoSingleton<T> instance;
    public static MonoSingleton<T> Instance
    {
        get
        {
            if (instance == null)
            {
                throw new System.Exception("Instance not found!");
            }
            else
            {
                return instance;
            }
        }
        private set
        {
            instance = value;
        }
    }

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
        OnAwake();
    }

    protected virtual void OnAwake() { }

    protected virtual void OnSceneLoaded(Scene aScene, LoadSceneMode aMode) { }

    void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        OnStart();
    }

    protected virtual void OnStart() { }

    private void OnApplicationQuit()
    {
        instance = null;
    }
}