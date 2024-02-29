using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasarIdleSeñalar : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public void PasarSeñalar()
    {
        animator.SetTrigger("señalar");
    }
}
