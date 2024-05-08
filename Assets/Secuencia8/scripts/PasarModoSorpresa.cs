using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasarModoSorpresa : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public void PasarSorpresa1()
    {
        animator.SetTrigger("Sorpresa1");
    }

    public void PasarSorpresaLateral()
    {
        animator.SetTrigger("sorpresaLateral");
    }

    public void PasarTaparseCabeza()
    {
        animator.SetTrigger("TaparseCabeza");
    }
}
