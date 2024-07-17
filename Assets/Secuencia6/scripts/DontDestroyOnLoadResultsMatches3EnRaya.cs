using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoadResultsMatches3EnRaya : MonoBehaviour
{
    //singleton
    static private DontDestroyOnLoadResultsMatches3EnRaya _instanceResults3EnRaya;

    //true or false
    //por defecto false porque se da por hecho que va a perder
    private bool winDificultMatch = false;


    //true or false
    //por defecto true porque se da por hecho que va a ganar
    private bool winEasyMatch = true;

    private string actualMatch = "";

    //singleton
    private void Awake()
    {

        //si la instancia no existe se hace este script la instancia
        if (_instanceResults3EnRaya == null)
        {
            _instanceResults3EnRaya = this;
            DontDestroyOnLoad(this.gameObject);

        }
        //si la instancia existe , destruimos la copia
        else
        {
            Destroy(this.gameObject);
        }
    }

    static public DontDestroyOnLoadResultsMatches3EnRaya GetInstanceUI()
    {
        return _instanceResults3EnRaya;
    }

    public void SetEasyMatchResultWin(bool set)
    {
        winEasyMatch = set;
    }

    public void SetDifficultMatchResultWin(bool set)
    {
        winDificultMatch = set;
    }

    public void SetActualMatch(string set)
    {
        actualMatch = set;
    }

    public bool GetEasyMatchResultWin()
    {
        return winEasyMatch;
    }

    public bool GetDifficultMatchResultWin()
    {
        return winDificultMatch;
    }

    public string GetActualMatch()
    {
        return actualMatch;
    }

    public void DestroyThis()
    {
        Destroy(this.gameObject);
    }



}
