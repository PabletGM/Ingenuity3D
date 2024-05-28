using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EleccionGenero : MonoBehaviour
{
    [SerializeField]
    private TMP_Text genderToChange;

    private string actualGender;

    private void Start()
    {
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
            genderToChange.text = "Masculino";
            actualGender = "Masculino";
        }
    }
}
