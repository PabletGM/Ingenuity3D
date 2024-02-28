using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasarDeIdleARun : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public void PasarIdleAWalk()
    {
        animator.SetTrigger("Walk");
    }
}
