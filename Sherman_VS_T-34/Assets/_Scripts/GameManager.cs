using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoSingleton<GameManager>
{
    float currentTime = 0f, startingTime = 60f;
    public bool roundStarted = false;
    public TextMeshProUGUI timerText;
    public int numOfShermanWins = 0, numOfTWins = 0;
    public GameObject playerOne, playerTwo;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        float dt = Time.deltaTime;

        if (roundStarted)
        {
            currentTime = Mathf.Max(0f, currentTime - dt);
            timerText.text = ((int)currentTime).ToString();
        }
    }
    public void StartGame()
    {
        LoadRandomScene();
    }

    private void LoadRandomScene()
    {
        SceneManager.LoadScene(Random.Range(2, SceneManager.sceneCountInBuildSettings)); ;
    }
    
}