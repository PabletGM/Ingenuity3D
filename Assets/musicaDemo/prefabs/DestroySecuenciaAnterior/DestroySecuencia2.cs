using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySecuencia2 : MonoBehaviour
{
    public void Destroy()
    {
        AudioManagerCirculos.instance.SetDestroy(true);
    }
}
