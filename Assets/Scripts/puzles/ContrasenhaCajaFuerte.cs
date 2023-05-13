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
    public void Borrar()
    {
        index++;
        num = null;
    }


}
