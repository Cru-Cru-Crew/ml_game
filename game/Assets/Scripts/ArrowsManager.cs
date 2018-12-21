using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowsManager : MonoBehaviour {

    public GameObject[] arrows;
    private GameObject currentArrow;

    private void Start()
    {
        currentArrow = arrows[0];
    }

    public void ChangeTo(int index)
    {
        currentArrow.SetActive(false);
        arrows[index].SetActive(true);
        currentArrow = arrows[index];
    }

    public void Disable()
    {
        currentArrow.SetActive(false);
    }
}
