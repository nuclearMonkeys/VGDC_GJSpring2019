using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class UIManager : MonoSingleton<UIManager>
{
    public GameObject[] panels;
    public Button[] shopButtons;
    public int curPanelsIndex = 0;
    public int curShopButtonsIndex = 0;
    public StandaloneInputModule module;
    public EventSystem eSys;

    protected override void OnSceneLoaded(Scene aScene, LoadSceneMode aMode)
    {
        if (aScene.buildIndex == 1)
        {
            SwitchPanels(2);
            eSys.firstSelectedGameObject = shopButtons[0].gameObject;
        }
        else
        {
            SwitchPanels(1);
        }
    }

    protected override void OnStart()
    {
        Transform canvas = transform.GetChild(0);
        panels = new GameObject[canvas.childCount];

        for (int i = 0; i < canvas.childCount; i++)
        {
            panels[i] = canvas.GetChild(i).gameObject;
        }

        shopButtons = panels[2].GetComponentsInChildren<Button>();
    }

    public void SwitchPanels(int indexOfPanelToActivate)
    {
        panels[curPanelsIndex].SetActive(false);
        panels[indexOfPanelToActivate].SetActive(true);
        curPanelsIndex = indexOfPanelToActivate;
    }

    public void PerformIconFading(int curIndex)
    {
        Color parentColor = shopButtons[curShopButtonsIndex].transform.parent.GetComponent<Image>().color;
        parentColor.a = .5f;
        shopButtons[curShopButtonsIndex].transform.parent.GetComponent<Image>().color = parentColor;

        curShopButtonsIndex = curIndex;

        parentColor = shopButtons[curShopButtonsIndex].transform.parent.GetComponent<Image>().color;
        parentColor.a = 1f;
        shopButtons[curShopButtonsIndex].transform.parent.GetComponent<Image>().color = parentColor;
    }

    public void SetModuleAxes(int i)
    {
        if (i == 1)
        {
            module.horizontalAxis = "DHor2";
            module.verticalAxis = "DVert2";
        }
        else if (i == 2)
        {
            module.horizontalAxis = "DHor1";
            module.verticalAxis = "DVert1";
            GameManager.Instance.LoadRandomScene();
        }
    }
}