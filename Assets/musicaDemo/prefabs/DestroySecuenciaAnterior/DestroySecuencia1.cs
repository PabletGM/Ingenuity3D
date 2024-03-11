using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySecuencia1 : MonoBehaviour
{
    public void Destroy()
    {
        AudioManagerIntro.instance.SetDestroy(true);
    }
}
