using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoSingleton<GameManager>
{
    float currentTime = 0f;
    float startingTime = 10f;

    public bool gameStarted = false;

    public int numOfShermanWins = 0;
    public int numOfTWins = 0;

    //public GameObject playerOne;
    //public GameObject playerTwo;

    // TODO:
    // Control scene changing
    // Amount of wins for two players
    void Start()
    {
        currentTime = startingTime;
    }

    void LateUpdate() {
        /*
        currentTime -= 1 * Time.deltaTime;
        print((int)currentTime);
        if (currentTime <= 0) {
            currentTime = 0;
        }
        */
    }
    public void StartGame()
    {
        LoadRandomScene();
    }

    private void LoadRandomScene()
    {
        SceneManager.LoadScene("LyndonScene");
        //SceneManager.LoadScene(Random.Range(1, SceneManager.sceneCountInBuildSettings)); ;
    }
    
}