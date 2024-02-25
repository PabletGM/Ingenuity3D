using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotLabIdleToBroken : MonoBehaviour
{

    [SerializeField] private Animator animator;
    public void PasarIdleToBroken()
    {
        animator.SetTrigger("Roto");
    }
}
