using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingRenderer : MonoBehaviour {

    public GameObject[] rendererListWoman;
    public GameObject[] rendererListMan;
    private GameObject actualRenderWoman;
    private GameObject actualRenderMan;
    private int actualIndexWoman;
    private int actualIndexMan;
    private bool isWoman;
    public GameObject man;
    public GameObject woman;

    private void Start()
    {
        isWoman = true;
        actualIndexWoman = 0;
        actualIndexMan = 0;
        actualRenderWoman = rendererListWoman[actualIndexWoman];
        actualRenderMan = rendererListMan[actualIndexMan];
    }

    public void ChangeToNext()
    {
        if(IsWoman())
        {
            actualIndexWoman++;
            if (actualIndexWoman >= rendererListWoman.Length)
            {
                actualIndexWoman = 0;
            }
            ChangeWomanRendererToNext(actualIndexWoman);
        } else
        {
            actualIndexMan++;
            if (actualIndexMan >= rendererListMan.Length)
            {
                actualIndexMan = 0;
            }
            ChangeManRendererToNext(actualIndexMan);
        }
    }

    public void ChangeToPrevious()
    {
        if(IsWoman())
        {
            actualIndexWoman--;
            if (actualIndexWoman < 0)
            {
                actualIndexWoman = rendererListWoman.Length - 1;
            }
            ChangeWomanRendererToNext(actualIndexWoman);
        } else
        {
            actualIndexMan--;
            if (actualIndexMan < 0)
            {
                actualIndexMan = rendererListMan.Length - 1;
            }
            ChangeManRendererToNext(actualIndexMan);
        }
    }

    private void ChangeWomanRendererToNext(int index)
    {
        actualRenderWoman.SetActive(false);
        rendererListWoman[index].SetActive(true);
        actualRenderWoman = rendererListWoman[index];
    }

    private void ChangeManRendererToNext(int index)
    {
        actualRenderMan.SetActive(false);
        rendererListMan[index].SetActive(true);
        actualRenderMan = rendererListMan[index];
    }

    private bool IsWoman()
    {
        return GameObject.Find("PanelsManager").GetComponent<PanelManager>().IsWoman();
    }
}
