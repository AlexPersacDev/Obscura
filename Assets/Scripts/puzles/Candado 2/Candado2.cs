using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Candado2 : MonoBehaviour
{
    //la contraseņa es 6084

    [SerializeField] CinemachineVirtualCamera playerLook;
    [SerializeField] CinemachineVirtualCamera zoomCandado2;

    [SerializeField] GameObject codigoIzq;
    [SerializeField] GameObject codigoIzqMedio;
    [SerializeField] GameObject codigodrchMedio;
    [SerializeField] GameObject codigodrch;

    [SerializeField] GameObject candado;
    Animator animCandado;

    int[] arrayNumeros = new int[4]; 
    int contadorA = 0;
    int contadorB = 0;
    int contadorC = 0;
    int contadorD = 0;

    void Start()
    {
        arrayNumeros[0] = 6;
        arrayNumeros[1] = 0;
        arrayNumeros[2] = 8;
        arrayNumeros[3] = 4;

        animCandado = candado.GetComponent<Animator>();
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
        if (contadorB>9)
        {
            contadorB = 0;
        }
        ComprobarContrasenha();
        codigoIzqMedio.transform.Rotate(new Vector3(36, 0, 0));
    }
    public void FlechaAbajoIzqMedio()
    {
        contadorB--;
        if (contadorB<0)
        {
            contadorB = 9;
        }
        ComprobarContrasenha();
        codigoIzqMedio.transform.Rotate(new Vector3(-36, 0, 0));
    }
    public void FlechArribaDrchMedio()
    {
        contadorC++;
        if (contadorC>9)
        {
            contadorC = 0;
        }
        ComprobarContrasenha();
        codigodrchMedio.transform.Rotate(new Vector3(36, 0, 0));
    }
    public void FlechAbajoDrchMedio()
    {
        contadorC--;
        if (contadorC<0)
        {
            contadorC = 9;
        }
        ComprobarContrasenha();
        codigodrchMedio.transform.Rotate(new Vector3(-36, 0, 0));
    }
    public void FlechArribaDrch()
    {
        contadorD++;
        if (contadorD>9)
        {
            contadorD = 0;
        }
        ComprobarContrasenha();
        codigodrch.transform.Rotate(new Vector3(36, 0, 0));
    }
    public void FlechAbajoDrch()
    {
        contadorD--;
        if (contadorD<0)
        {
            contadorD = 9;
        }
        ComprobarContrasenha();
        codigodrch.transform.Rotate(new Vector3(-36, 0, 0));
    }

    void ComprobarContrasenha()
    {
        //ver si la cajita del array coicide con el num INDIVIDUALMENTE
        if (arrayNumeros[0]== contadorA&&arrayNumeros[1]==contadorB&&arrayNumeros[2]==contadorC&& arrayNumeros[3]==contadorD)
        {
            //se abre el candado
            Debug.Log("Has abierto el candado");
            animCandado.SetBool("SeHaAbierto",true);
            //candado.SetActive(false);
        }
    }
    //public void EventoAnimacion()
    //{
    //    candado.SetActive(false);
    //}
}
