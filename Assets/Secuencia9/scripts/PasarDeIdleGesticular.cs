using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasarDeIdleGesticular : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public void PasarGesticular()
    {
        animator.SetTrigger("gesticular");
    }
}
