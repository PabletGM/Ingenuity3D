using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasarIdleCogerObjeto : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public void PasarCogerObjeto()
    {
        animator.SetTrigger("CogerObjeto");
    }
}
