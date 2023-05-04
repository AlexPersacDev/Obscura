using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuRotacionCamara : MonoBehaviour
{
    
    void Start()
    {
        Vector3 rotacionActual = transform.eulerAngles;

        if (rotacionActual.y < 25&&rotacionActual.y>=0)//no ha rotado del todo a la derecha
        {

        }
        else if(rotacionActual.y>-25&&rotacionActual.y)
        {

        }
    }

    
    void Update()
    {
        
    }
   //25,-25
}
