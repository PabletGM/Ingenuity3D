using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySecuencia4 : MonoBehaviour
{
    public void Destroy()
    {
        AudioManagerSecuencia4.instance.SetDestroy(true);
    }
}
