using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MenuSonidos : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    void Start()
    {
        
    }

  
    void Update()
    {
        
    }
    public void SliderMaster(float volumenRecibido)
    {
        audioMixer.SetFloat("VolumenMaster", Mathf.Log10(volumenRecibido) * 20);
    }
}
