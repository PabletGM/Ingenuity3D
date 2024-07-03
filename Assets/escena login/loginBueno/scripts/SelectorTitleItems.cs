using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SelectorTitleItems : MonoBehaviour
{

    // Referencia al UIManagerLogin
    static private GenreLoginRegisterChosen genreChosen;

    //title of item to change
    [SerializeField]
    private TMP_Text titleItemGenre;

    public string titleItemMasculine;

    public string titleItemFemenine;

    public string titleItemNeutre;


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
            if (genreChosen.GetActualGenderLogin() != "unknown")
            {
                genderChosen = genreChosen.GetActualGenderLogin();
                Debug.Log(genreChosen.GetActualGenderLogin());
                ChangeItemDependingOfGender(genderChosen);
            }
            //second on register, if it has done register
            else if (genreChosen.GetActualGenderRegister() != "unknown")
            {
                genderChosen = genreChosen.GetActualGenderRegister();
                Debug.Log(genreChosen.GetActualGenderRegister());
                ChangeItemDependingOfGender(genderChosen);
            }
        }
    }
    private void ChangeItemDependingOfGender(string gender)
    {
        if (gender == "male")
        {
            titleItemGenre.text = titleItemMasculine;
        }
        else if (gender == "female")
        {
            titleItemGenre.text = titleItemFemenine;
        }
        else if (gender == "")
        {
            titleItemGenre.text = titleItemNeutre;
        }
    }
}
