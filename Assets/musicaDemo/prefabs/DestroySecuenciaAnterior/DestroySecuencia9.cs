using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySecuencia9 : MonoBehaviour
{
    public void Destroy()
    {
        AudioManagerSecuencia9.instance.SetDestroy(true);

    }
}
