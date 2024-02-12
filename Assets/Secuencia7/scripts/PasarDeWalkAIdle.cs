using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//comportamiento que a través de un evento de animacion trigger se pone en idle
public class PasarDeWalkAIdle : MonoBehaviour
{

    [SerializeField] private Animator animator;
    public void PasarWalkIdle()
    {
        animator.SetTrigger("Idle");
    }
}
