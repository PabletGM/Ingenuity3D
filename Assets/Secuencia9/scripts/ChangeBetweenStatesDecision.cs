using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBetweenStatesDecision : MonoBehaviour
{
    [Header("Sprites references")]
    [SerializeField]
    private Image spriterenderer;
    [SerializeField]
    private Sprite firstSprite;
    [SerializeField]
    private Sprite secondSprite;
    [SerializeField]
    private Sprite thirdSprite;

    [Header("timeBetweenImageChange")]
    [SerializeField]
    private float timeFirstToSecond;
    [SerializeField]
    private float timeSecondToThird;
    [SerializeField]
    private float timeThirdToFirst;


    private void Start()
    {
        Invoke("ChangeFromFirstToSecond", timeFirstToSecond);
    }

    private void ChangeFromFirstToSecond()
    {
        spriterenderer.sprite = secondSprite;
        Invoke("ChangeFromSecondToThird", timeFirstToSecond);
    }

    private void ChangeFromSecondToThird()
    {
        spriterenderer.sprite = thirdSprite;
        Invoke("ChangeFromThirdToFirst", timeSecondToThird);
    }

    private void ChangeFromThirdToFirst()
    {
        spriterenderer.sprite = firstSprite;
        Invoke("ChangeFromFirstToSecond", timeThirdToFirst);
    }
}
