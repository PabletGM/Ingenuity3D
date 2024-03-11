using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySecuencia3 : MonoBehaviour
{
    public void Destroy()
    {
        AudioManagerBengalas.instance.SetDestroy(true);
    }
}
