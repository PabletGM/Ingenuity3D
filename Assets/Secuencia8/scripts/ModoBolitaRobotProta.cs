using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModoBolitaRobotProta : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public void PasarBrazosABolita()
    {
        animator.SetTrigger("Bola");
    }
}
