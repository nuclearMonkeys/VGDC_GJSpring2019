using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoSingleton<GameManager>
{
    public void StartGame()
    {
        LoadRandomScene();
    }

    private void LoadRandomScene()
    {
        SceneManager.LoadScene(Random.Range(1, SceneManager.sceneCountInBuildSettings)); ;
    }
}