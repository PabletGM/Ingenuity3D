using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverBigSmall : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI buttonText;
    public Vector3 normalScale = new Vector3(1f, 1f, 1f);
    public Vector3 hoverScale = new Vector3(1.2f, 1.2f, 1.2f);
    public float animationDuration = 0.2f;

    public Color normalColor;
    public Color hoverColor;

    private void Start()
    {
        if (buttonText == null)
        {
            buttonText = GetComponentInChildren<TextMeshProUGUI>();
        }
        buttonText.transform.localScale = normalScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        StopAllCoroutines();
        StartCoroutine(ScaleText(buttonText.transform, hoverScale));
        buttonText.color = hoverColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        StopAllCoroutines();
        StartCoroutine(ScaleText(buttonText.transform, normalScale));
        buttonText.color = normalColor;
    }

    private IEnumerator ScaleText(Transform target, Vector3 toScale)
    {
        Vector3 startScale = target.localScale;
        float elapsedTime = 0f;

        while (elapsedTime < animationDuration)
        {
            target.localScale = Vector3.Lerp(startScale, toScale, (elapsedTime / animationDuration));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        target.localScale = toScale;
    }
}
