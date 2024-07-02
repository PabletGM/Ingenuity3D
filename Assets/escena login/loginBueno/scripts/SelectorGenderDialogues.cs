using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorGenderDialogues : MonoBehaviour
{

    // Referencia al UIManagerLogin
    static private GenreLoginRegisterChosen genreChosen;

    //options depending of gender
    [SerializeField]
    private GameObject dialogueMasculine;
    [SerializeField]
    private GameObject dialogueFemenine;
    [SerializeField]
    private GameObject dialogueNeutre;

    // Start is called before the first frame update
    void Start()
    {
        genreChosen = GenreLoginRegisterChosen.GetInstanceUI();
        //comprobamos si existe la instancia UIManagerLogin
        if (genreChosen != null)
        {
            //ask for the gender
            string genderChosen;
            //first on login, if it has done login
            if(genreChosen.GetActualGenderLogin() != "unknown")
            {
                genderChosen = genreChosen.GetActualGenderLogin();
                Debug.Log(genreChosen.GetActualGenderLogin());
                ChangeDialogueDependingOfGender(genderChosen);
            }
            //second on register, if it has done register
            else if(genreChosen.GetActualGenderRegister() != "unknown")
            {
                genderChosen = genreChosen.GetActualGenderRegister();
                Debug.Log(genreChosen.GetActualGenderRegister());
                ChangeDialogueDependingOfGender(genderChosen);
            }
        }
    }

    private void ChangeDialogueDependingOfGender(string gender)
    {
        if(gender == "male")
        {
            dialogueMasculine.SetActive(true);
            dialogueFemenine.SetActive(false);
            dialogueNeutre.SetActive(false);
        }
        else if(gender == "female")
        {
            dialogueMasculine.SetActive(false);
            dialogueFemenine.SetActive(true);
            dialogueNeutre.SetActive(false);
        }
        else if(gender == "")
        {
            dialogueMasculine.SetActive(false);
            dialogueFemenine.SetActive(false);
            dialogueNeutre.SetActive(true);
        }
    }

   
}
