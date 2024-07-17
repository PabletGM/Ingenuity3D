using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorResultMatches3EnRaya : MonoBehaviour
{
    // Referencia
    static private DontDestroyOnLoadResultsMatches3EnRaya _instanceResults3EnRaya;

    //options depending of match and victory
    //[SerializeField]
    //private GameObject dialogueWinMatch3EnRayaDificil;
    //[SerializeField]
    //private GameObject dialogueLoseMatch3EnRayaDificil;

    [SerializeField]
    private GameObject dialogueWinMatch3EnRayaFacil;
    [SerializeField]
    private GameObject dialogueLoseMatch3EnRayaFacil;

    // Start is called before the first frame update
    void Start()
    {
        _instanceResults3EnRaya = DontDestroyOnLoadResultsMatches3EnRaya.GetInstanceUI();
        if(_instanceResults3EnRaya != null )
        {
            ////first check on what Level we are
            //if (_instanceResults3EnRaya.GetActualMatch() == "dificult")
            //{
            //    //si ha perdido el difficult
            //    if(!_instanceResults3EnRaya.GetDifficultMatchResultWin())
            //    {
            //        dialogueLoseMatch3EnRayaDificil.SetActive(true);
            //        dialogueWinMatch3EnRayaDificil.SetActive(false);
            //    }
            //    //si ha ganado el difficult
            //    else
            //    {
            //        dialogueLoseMatch3EnRayaDificil.SetActive(false);
            //        dialogueWinMatch3EnRayaDificil.SetActive(true);
            //    }
            //}

            //first check on what Level we are
            if (_instanceResults3EnRaya.GetActualMatch() == "easy")
            {
                //si ha ganado el easy
                if (_instanceResults3EnRaya.GetEasyMatchResultWin())
                {
                    dialogueWinMatch3EnRayaFacil.SetActive(true);
                    dialogueLoseMatch3EnRayaFacil.SetActive(false);
                }
                //si ha perdido el easy
                else
                {
                    dialogueWinMatch3EnRayaFacil.SetActive(false);
                    dialogueLoseMatch3EnRayaFacil.SetActive(true);
                }
            }
        }

        _instanceResults3EnRaya.DestroyThis();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
