using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoSingleton<GameManager>
{
    float currentTime = 0f;
    float startingTime = 61f;

    public bool gameStarted = false;
    public TextMeshProUGUI timerText;

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
        if (gameStarted)
        {
            
            currentTime -= 1 * Time.deltaTime;
            timerText.text = ((int)currentTime).ToString();
            if (currentTime <= 0)
            {
                currentTime = 0;
            }
        }
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