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


    private void Start()
    {
        //initiliace list
        generosLista=new List<string>();
        //add generos
        //init actualGender
        actualGender = "Masculino";
    }


  

    public void ChangeGender()
    {
        if(actualGender == "Masculino")
        {
            genderToChange.text = "Femenino";
            actualGender = "Femenino";
        }
        else if (actualGender == "Femenino")
        {
            genderToChange.text = "Otro";
            actualGender = "Otro";
        }
        else if (actualGender == "Otro")
        {
            genderToChange.text = "Masculino";
            actualGender = "Masculino";
        }
    }

   
}
