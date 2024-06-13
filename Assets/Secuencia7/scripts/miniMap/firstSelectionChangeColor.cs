using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class firstSelectionChangeColor : MonoBehaviour
{

    [SerializeField]
    private GameObject image;

    [SerializeField]
    private Sprite newSprite;

    [SerializeField]
    private GameObject selectedGoodIndication;


    public void FirstSelectionChangeColor()
    {
        //onclick the rest of the buttons the color stays yellow
        //so it quits the preselection
        image.GetComponent<Image>().sprite = newSprite;
        //take out the good indication
        selectedGoodIndication.SetActive(false);
    }
}
