using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySecuencia8 : MonoBehaviour
{
    public void Destroy()
    {
        AudioManagerSecuencia8.instance.SetDestroy(true);

    }
}
