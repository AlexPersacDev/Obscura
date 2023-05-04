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
        SceneManager.LoadScene("Beta");
    }
    public void Opciones()
    {
        SceneManager.LoadScene("MenuOpciones");
    }
    public void Salir()
    {
        Application.Quit();
    }
    public void CalidadGrafica(int indiceCalidad)
    {
        QualitySettings.SetQualityLevel(indiceCalidad);
    }
    public void Exit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
