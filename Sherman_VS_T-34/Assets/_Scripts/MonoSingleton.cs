using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
    private static T instance;
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<T>();

                if (instance == null)
                {
                    GameObject obj = new GameObject(typeof(T).Name);
                    instance = obj.AddComponent<T>();
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        instance = this as T;
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