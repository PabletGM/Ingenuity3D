using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySecuencia5 : MonoBehaviour
{
    public void Destroy()
    {
        AudioManager.Instance.SetDestroy(true);
    }
}
