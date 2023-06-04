using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    [SerializeField] GameObject opciones;
    [SerializeField] CanvasManager cM;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void BotonPausa()
    {
        opciones.SetActive(true);
    }
    public void CerrarMenu()
    {
        opciones.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
        cM.EnableMirilla();
    }
       
}
