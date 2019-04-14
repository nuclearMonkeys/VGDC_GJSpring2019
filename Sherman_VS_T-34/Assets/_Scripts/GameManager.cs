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
    public PlayerHealth p1HP, p2HP;
    public SimplePlayerMovement p1Mov, p2Mov;
    public SimplePlayerShoot p1Shoot, p2Shoot;
    public enum Powerups { NA, SpeedBoost, Shield, IncFirePower, IncFireRate};
    public Powerups P1State = Powerups.NA, P2State = Powerups.NA;
    public int playerWithFocus = 1;

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
        SceneManager.LoadScene(Random.Range(2, SceneManager.sceneCountInBuildSettings));
    }

    public void ApplyPowerup(int i)
    {
        Powerups p = (Powerups)i;
        string p1 = "PlayerOne", p2 = "PlayerTwo", s = playerWithFocus == 1 ? p1 : p2;

        switch (p)
        {
            case Powerups.NA:
                break;
            case Powerups.SpeedBoost:
                {
                    if (s == p1)
                    {
                        p1Mov.speed *= 2f;
                        P1State = p;
                    }
                    else if (s == p2)
                    {
                        p2Mov.speed *= 2f;
                        P2State = p;
                    }
                }
                break;
            case Powerups.Shield:
                {
                    if (s == p1)
                    {
                        p1HP.isInvincible = true;
                        P1State = p;
                    }
                    else if (s == p2)
                    {
                        p2HP.isInvincible = false;
                        P2State = p;
                    }
                }
                break;
            case Powerups.IncFirePower:
                {
                    if (s == p1)
                    {
                        p1Shoot.damagePerBullet *= 2;
                        P1State = p;
                    }
                    else if (s == p2)
                    {
                        p1Shoot.damagePerBullet *= 2;
                        P2State = p;
                    }
                }
                break;
            case Powerups.IncFireRate:
                {
                    if (s == p1)
                    {
                        p1Shoot.time_scale /= 2f;
                        P1State = p;
                    }
                    else if (s == p2)
                    {
                        p1Shoot.time_scale /= 2f;
                        P2State = p;
                    }
                }
                break;
        }

        if (s == p1)
        {
            playerWithFocus = 2;
            UIManager.Instance.SetModuleAxes(1);
        }
        else if (s == p2)
        {
            playerWithFocus = 1;
            UIManager.Instance.SetModuleAxes(2);
        }
    }

    public void RemovePowerups()
    {
        if (P1State != Powerups.NA)
        {
            switch (P1State)
            {
                case Powerups.SpeedBoost:
                    {
                        p1Mov.speed /= 2f;
                    }
                    break;
                case Powerups.Shield:
                    {
                        p1HP.isInvincible = false;
                    }
                    break;
                case Powerups.IncFirePower:
                    {
                        p1Shoot.damagePerBullet /= 2;
                    }
                    break;
                case Powerups.IncFireRate:
                    {
                        p1Shoot.time_scale *= 2f;
                    }
                    break;
            }
            P1State = Powerups.NA;
        }

        if (P2State != Powerups.NA)
        {
            switch (P2State)
            {
                case Powerups.SpeedBoost:
                    {
                        p2Mov.speed /= 2f;
                    }
                    break;
                case Powerups.Shield:
                    {
                        p2HP.isInvincible = false;
                    }
                    break;
                case Powerups.IncFirePower:
                    {
                        p2Shoot.damagePerBullet /= 2;
                    }
                    break;
                case Powerups.IncFireRate:
                    {
                        p2Shoot.time_scale *= 2f;
                    }
                    break;
            }
            P2State = Powerups.NA;
        }
    }
}