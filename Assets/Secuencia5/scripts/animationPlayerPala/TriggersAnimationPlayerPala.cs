using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggersAnimationPlayerPala : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public void PasarAIdle()
    {
        animator.SetTrigger("Idle");
    }

    public void PasarAWalk()
    {
        animator.SetTrigger("walk");
    }

    public void PasarAPicada()
    {
        animator.SetTrigger("Picada");
    }

   
}
