using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoSingleton<UIManager>
{
    public GameObject[] panels;
    public int curPanelsIndex = 0;

    public void SwitchPanels(int indexOfPanelToActivate)
    {
        panels[curPanelsIndex].SetActive(false);
        panels[indexOfPanelToActivate].SetActive(true);
        curPanelsIndex = indexOfPanelToActivate;
    }
}