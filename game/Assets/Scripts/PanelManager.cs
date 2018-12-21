using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour {

    public GameObject mainPanelWoman;
    public GameObject secondaryPanelWoman;
    public GameObject mainPanelMan;
    public GameObject secondaryPanelMan;
    public GameObject man;
    public GameObject woman;
    private bool isWoman;

    private GameObject currentPanel;

    void Start()
    {
        isWoman = true;
        currentPanel = mainPanelWoman;
    }

    public void EnableMainPanelWoman()
    {
        woman.SetActive(true);
        man.SetActive(false);
        isWoman = true;
        currentPanel.SetActive(false);
        mainPanelWoman.SetActive(true);
        currentPanel = mainPanelWoman;
    }

    public void EnableSecondaryPanelWoman()
    {
        currentPanel.SetActive(false);
        secondaryPanelWoman.SetActive(true);
        currentPanel = secondaryPanelWoman;
    }

    public void EnableMainPanelMan()
    {
        woman.SetActive(false);
        man.SetActive(true);
        isWoman = false;
        currentPanel.SetActive(false);
        mainPanelMan.SetActive(true);
        currentPanel = mainPanelMan;
    }

    public void EnableSecondaryPanelMan()
    {
        currentPanel.SetActive(false);
        secondaryPanelMan.SetActive(true);
        currentPanel = secondaryPanelMan;
    }

    public bool IsWoman()
    {
        return isWoman;
    }
}
