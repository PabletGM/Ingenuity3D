using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialOffsetController : MonoBehaviour
{
    public Material originalMaterial;
    private Material clonedMaterial;
    public float aumentoOffsetX = 0.25f;

    void Start()
    {
        CloneMaterial();
        PonerOffseta0();
        InvokeRepeating("AumentarTextureOffset", 1f, 1f);
    }

    private void CloneMaterial()
    {
        // Clona el material para no afectar al original
        clonedMaterial = new Material(originalMaterial);
        GetComponent<Renderer>().material = clonedMaterial;
    }

    private void AumentarTextureOffset()
    {
        // Asegúrate de que el material tiene textura principal y su propiedad '_MainTex'
        if (clonedMaterial.HasProperty("_MainTex"))
        {
            // Obtén el offset actual
            Vector2 offset = clonedMaterial.GetTextureOffset("_MainTex");

            // Calcula el nuevo offset 
            float offsetX = offset.x + aumentoOffsetX;
            float offsetY = offset.y;

            // Aplica el nuevo offset al material clonado
            clonedMaterial.SetTextureOffset("_MainTex", new Vector2(offsetX, offsetY));
        }
        else
        {
            Debug.LogError("El material clonado no tiene una textura principal o su propiedad '_MainTex'.");
        }
    }

    private void PonerOffseta0()
    {
        // Asegúrate de que el material clonado tiene textura principal y su propiedad '_MainTex'
        if (clonedMaterial.HasProperty("_MainTex"))
        {
            // Establece el offset del material clonado a 0
            clonedMaterial.SetTextureOffset("_MainTex", Vector2.zero);
        }
        else
        {
            Debug.LogError("El material clonado no tiene una textura principal o su propiedad '_MainTex'.");
        }
    }
}
