using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuRotacionCamara : MonoBehaviour
{
    Vector3 rotDerecha;
    Vector3 rotIzquierda;
    Vector3 rotInicial;

    bool moviendoDerecha=true;
    bool moviendoIzquierda;
    void Start()
    {
        rotInicial = transform.eulerAngles;

        rotDerecha = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 10, transform.eulerAngles.z);
        rotIzquierda = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 10, transform.eulerAngles.z);

       
    }

    
    void Update()
    {
        //transform.eulerAngles += new Vector3(0, 1, 0) * Time.deltaTime;
        Vector3 rotacionActual = transform.eulerAngles;

        if (moviendoDerecha)
        {
            transform.eulerAngles += new Vector3(0, 1, 0) * Time.deltaTime;

            if (rotacionActual.y>=rotDerecha.y)
            {
                moviendoDerecha = false;
            }
        }
        if (moviendoDerecha==false)
        {
            transform.eulerAngles += new Vector3(0, -1, 0) * Time.deltaTime;

            if (rotacionActual.y<=rotIzquierda.y)
            {
                moviendoDerecha = true;
            }
        }


        //Debug.Log("" + rotacionActual);

        //if (rotacionActual.y <  rotDerecha.y && rotacionActual.y >= rotInicial.y)//no ha rotado del todo a la derecha
        //{
        //    //roto hacia la derecha
        //    Debug.Log("a");
        //    transform.eulerAngles += new Vector3(0, 1, 0) * Time.deltaTime;
        //}
        //else if (rotacionActual.y > rotIzquierda.y )//no ha rotado del todo a la izquierda
        //{
        //    //roto hacia la derecha
        //    transform.eulerAngles += new Vector3(0, -1, 0) * Time.deltaTime;
        //}
        //else if (rotacionActual.y == rotDerecha.y)
        //{
        //    Debug.Log("hola mundo");
        //}
        

    }
   //25,-25
}
