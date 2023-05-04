using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BotonesMenu : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Empezar()
    {
        SceneManager.LoadScene("Blocking_01");
    }
    public void Opciones()
    {

    }
    public void Salir()
    {

    }
    public void CalidadGrafica(int indiceCalidad)
    {
        QualitySettings.SetQualityLevel(indiceCalidad);
    }
}
