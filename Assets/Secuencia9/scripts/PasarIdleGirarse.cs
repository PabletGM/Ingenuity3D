using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasarIdleGirarse : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public void PasarGirarse()
    {
        animator.SetTrigger("Girarse");
    }
}
