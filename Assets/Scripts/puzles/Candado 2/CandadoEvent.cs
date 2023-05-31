using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandadoEvent : MonoBehaviour
{
    [SerializeField] GameObject puerta;
    Animator animPuerta;
    void Start()
    {
        animPuerta = puerta.GetComponent<Animator>();
    }
    public void EventoAnimacion()
    {
        this.gameObject.SetActive(false);
        animPuerta.SetTrigger("Opening");
    }
}
