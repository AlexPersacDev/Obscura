using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Candado2 : MonoBehaviour
{
    //la contraseña es 6084

    [SerializeField] CinemachineVirtualCamera playerLook;
    [SerializeField] CinemachineVirtualCamera zoomCandado2;

    [SerializeField] GameObject codigoIzq;
    [SerializeField] GameObject codigoIzqMedio;
    [SerializeField] GameObject codigodrchMedio;
    [SerializeField] GameObject codigodrch;
    void Start()
    {
        
    }

    
    void Update()
    {
        //-144 el de la izq = 6
        if (codigoIzq.transform.eulerAngles==new Vector3(-144,0,0))
        {
            Debug.Log("Primer numero bien");
        }
        else
        {
            Debug.Log("primer num mal");
        }
        //segundo num rot 0 = 0
        if (codigoIzqMedio.transform.eulerAngles== new Vector3(0,0,0))
        {
            Debug.Log("Segundo numero bien");
        }
        else
        {
            Debug.Log("Segundo num mal");
        }
        //tercer num -72 rot = 8
        if (codigodrchMedio.transform.eulerAngles==new Vector3(-72,0,0))
        {
            Debug.Log("Tercer numero bien");
        }
        else
        {
            Debug.Log("Tercer num mal");
        }
        //ultimjo num 144 rot = 4
        if (codigodrch.transform.eulerAngles==new Vector3(144,0,0))
        {
            Debug.Log("Cuarto numero bien");
        }
        else
        {
            Debug.Log("Cuarto num mal");
        }
    }

    public void FlechaArribaIzq()
    {
        codigoIzq.transform.Rotate(new Vector3(36, 0, 0));
    }
    public void FlechaAbajoIzq()
    {
        codigoIzq.transform.Rotate(new Vector3(-36, 0, 0));
    }
    public void FlechaArribaIzqMedio()
    {
        codigoIzqMedio.transform.Rotate(new Vector3(36, 0, 0));
    }
    public void FlechaAbajoIzqMedio()
    {
        codigoIzqMedio.transform.Rotate(new Vector3(-36, 0, 0));
    }
    public void FlechArribaDrchMedio()
    {
        codigodrchMedio.transform.Rotate(new Vector3(36, 0, 0));
    }
    public void FlechAbajoDrchMedio()
    {
        codigodrchMedio.transform.Rotate(new Vector3(-36, 0, 0));
    }
    public void FlechArribaDrch()
    {
        codigodrch.transform.Rotate(new Vector3(36, 0, 0));
    }
    public void FlechAbajoDrch()
    {
        codigodrch.transform.Rotate(new Vector3(-36, 0, 0));
    }
}
