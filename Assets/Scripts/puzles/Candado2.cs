using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Candado2 : MonoBehaviour
{
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
