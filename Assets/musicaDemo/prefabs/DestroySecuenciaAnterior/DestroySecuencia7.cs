using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySecuencia7 : MonoBehaviour
{
    public void Destroy()
    {
        AudioManagerSecuencia6.instance.SetDestroy(true);
        AudioManagerSecuencia7.instance.SetDestroy(true);
    }
}
