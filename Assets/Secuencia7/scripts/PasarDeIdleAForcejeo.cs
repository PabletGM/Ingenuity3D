using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//comportamiento que a trav�s de un evento de animacion trigger se pone en idle
public class PasarDeIdleAForcejeo : MonoBehaviour
{

    [SerializeField] private Animator animator;
    public void PasarIdleForcejeo()
    {
        animator.SetTrigger("Forcejeo");
    }
}
