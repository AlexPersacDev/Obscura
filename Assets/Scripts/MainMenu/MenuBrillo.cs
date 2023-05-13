using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuBrillo : MonoBehaviour
{
    public Slider slider;
    public float valorSlider;
    public Image panelBrillo;
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("brillo", 0.5f);

        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, slider.value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CambiarSlider(float valor)
    {
        valorSlider = valor;
        PlayerPrefs.SetFloat("brillo", valorSlider);
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, slider.value);
    }
}
