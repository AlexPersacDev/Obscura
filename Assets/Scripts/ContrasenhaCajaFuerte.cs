using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContrasenhaCajaFuerte : MonoBehaviour
{
    string contra = "3105";
    string num = null;
    int index = 0;

    public void Codigo(string numeros)
    {
        index++;
        num = num + numeros;
        Debug.Log(""+num);
    }
    public void Enter()
    {
        if (num == contra)
        {
            Debug.Log("Suuuu");
        }
    }



























    ////la contraseña es 3105

    //bool primerNum = false;
    //bool segundoNum = false;
    //bool tercerNum = false;
    //bool cuartoNum = false;

    //bool hasPulsadoUnBoton = false; //esta variable la uso para que si presiona primero el 3, ver si se ha pulsado antes algún boton

    //void Start()
    //{

    //}
    //void Update()
    //{

    //}

    //public void PresionarUno()
    //{

    //    bool hasPulsadoUnBoton = true;
    //    Debug.Log(""+hasPulsadoUnBoton);
    //}
    //public void PresionarDos()
    //{
    //    bool hasPulsadoUnBoton = true;
    //}
    //public void PresionarTres()
    //{

    //    if (hasPulsadoUnBoton == true)//no es el primer numero
    //    {
    //        Debug.Log("ya vas mal");
    //    }
    //    else
    //    {
    //        Debug.Log("3 es tu primer num");
    //        primerNum = true;
    //    }
    //}
    //public void PresionarCuatro()
    //{
    //    bool hasPulsadoUnBoton = true;
    //}
    //public void PresionarCinco()
    //{
    //    bool hasPulsadoUnBoton = true;
    //}
    //public void PresionarSeis()
    //{
    //    bool hasPulsadoUnBoton = true;
    //}
    //public void PresionarSiete()
    //{
    //    bool hasPulsadoUnBoton = true;
    //}
    //public void PresionarOcho()
    //{
    //    bool hasPulsadoUnBoton = true;
    //}
    //public void PresionarNueve()
    //{
    //    bool hasPulsadoUnBoton = true;
    //}
    //public void PresionarCero()
    //{
    //    bool hasPulsadoUnBoton = true;
    //}
}
