using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySecuencia6 : MonoBehaviour
{
    public void Destroy()
    {
        AudioManagerSecuencia6.instance.SetDestroy(true);
    }
}
