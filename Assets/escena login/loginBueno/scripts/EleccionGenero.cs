using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class EleccionGenero : MonoBehaviour
{
    [SerializeField]
    private TMP_Text genderToChange;

    private string actualGender;

    public List<string> generosLista;

    private UIManagerLogin uiManagerLogin;


    private void Start()
    {
        //connect to uiManagerLogin
        uiManagerLogin = UIManagerLogin.GetInstanceUI();
        //initiliace list
        generosLista =new List<string>();
        //add generos
        //init actualGender
        actualGender = "male";
    }


  

    public void ChangeGender()
    {
        if(genderToChange.text == "Masculino")
        {
            genderToChange.text = "Femenino";
            actualGender = "female";
        }
        else if (genderToChange.text == "Femenino")
        {
            genderToChange.text = "Otro";
            actualGender = "other";
        }
        else if( genderToChange.text == "Otro")
        {
            genderToChange.text = "Masculino";
            actualGender = "male";
        }

        uiManagerLogin.actualGender = actualGender;
    }

   
}
