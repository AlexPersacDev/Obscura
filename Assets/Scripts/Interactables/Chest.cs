using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour, IInteractuable
{
    public void Interact()
    {
        Animator baulAnim = GetComponent<Animator>();//pillo su animator
        baulAnim.SetTrigger("Opening");//activo la animación
        gameObject.layer = 0; //deja de ser interactuable
        GetComponent<Collider>().enabled = false;
    }
}
