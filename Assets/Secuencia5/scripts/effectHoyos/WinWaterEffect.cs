using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinWaterEffect : MonoBehaviour
{
    [SerializeField]
    private GameObject[] waterHoyosVFX;

    [SerializeField]
    private GameObject waterEnvironment;



    public void StartTransitionWin()
    {
        StartWaterTransitionHoyo0();
    }

    public void StartWaterTransitionHoyo0()
    {
        waterHoyosVFX[0].SetActive(true);
        Invoke("StartWaterTransitionHoyo1", 0.5f);
    }

    public void StartWaterTransitionHoyo1()
    {
        waterHoyosVFX[1].SetActive(true);
        Invoke("StartWaterTransitionHoyo2", 0.5f);
    }

    public void StartWaterTransitionHoyo2()
    {
        //begins water environment
        waterEnvironment.SetActive(true);
        waterHoyosVFX[2].SetActive(true);
        Invoke("StartWaterTransitionHoyo3", 0.5f);
    }

    public void StartWaterTransitionHoyo3()
    {
        waterHoyosVFX[3].SetActive(true);
        Invoke("StartWaterTransitionHoyo4", 0.5f);
    }

    public void StartWaterTransitionHoyo4()
    {
        waterHoyosVFX[4].SetActive(true);
        Invoke("StartWaterTransitionHoyo5", 0.5f);
    }

    public void StartWaterTransitionHoyo5()
    {
        waterHoyosVFX[5].SetActive(true);
       
    }

}
