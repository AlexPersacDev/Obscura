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

    int[] arrayNumeros = new int[4]; 
    int contadorA = 0;
    int contadorB = 0;
    int contadorC = 0;
    int contadorD = 0;
    void Start()
    {
       
    }

    
    void Update()
    {
        
    }

    public void FlechaArribaIzq()
    {
        contadorA++;
        if(contadorA > 9)
        {
            contadorA = 0;
        }
        ComprobarContrasenha();
        codigoIzq.transform.Rotate(new Vector3(36, 0, 0));
    }
    public void FlechaAbajoIzq()
    {
        contadorA--;
        if(contadorA < 0)
        {
            contadorA = 9;
        }
        ComprobarContrasenha();
        codigoIzq.transform.Rotate(new Vector3(-36, 0, 0));
    }
    public void FlechaArribaIzqMedio()
    {
        contadorB++;
        if (contadorB<0)
        {
            contadorB = 9;
        }
        ComprobarContrasenha();
        codigoIzqMedio.transform.Rotate(new Vector3(36, 0, 0));
    }
    public void FlechaAbajoIzqMedio()
    {
        contadorB--;
        if (contadorB)
        {

        }
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

    void ComprobarContrasenha()
    {
        //ver si la cajita del array coicide con el num INDIVIDUALMENTE
        if (arrayNumeros[0]== contadorA&&arrayNumeros[1]==contadorB&&arrayNumeros[2]==contadorC&& arrayNumeros[3]==contadorD)
        {
            //se abre el candado
        }
    }
}
