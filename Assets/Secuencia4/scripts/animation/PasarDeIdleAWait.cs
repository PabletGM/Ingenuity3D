using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasarDeIdleAWait : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public void PasarWalkIdle()
    {
        animator.SetTrigger("Wait");
    }
}
