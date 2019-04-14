using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoSingleton<UIManager>
{
    public GameObject[] panels;
    public Button[] shopButtons;
    public int curPanelsIndex = 0;
    public int curShopButtonsIndex = 0;

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
}