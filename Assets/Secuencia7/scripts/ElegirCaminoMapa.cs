using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElegirCaminoMapa : MonoBehaviour
{
    [HideInInspector]
    public static ElegirCaminoMapa instance;

    private void Awake()
    {
        if (instance == null )
        {
            instance = this;
            DontDestroyOnLoad( this );
        }
        else
        {
            Destroy( this.gameObject );
        }
    }
    private string chosenOption = "";

    public void ChooseWayRio()
    {
        chosenOption = "Rio";
    }

    public void ChooseWayCaminoEstablecido()
    {
        chosenOption = "CaminoEstablecido";
    }

    public void ChooseWayBosque()
    {
        chosenOption = "Bosque";
    }

    public string GetChosenOption()
    {
        return chosenOption;
    }
}
