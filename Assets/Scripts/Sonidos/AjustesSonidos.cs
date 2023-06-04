using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AjustesSonidos : MonoBehaviour
{
    [SerializeField] AudioMixer mixer;
    [SerializeField] Slider musica;
    [SerializeField] Slider sfx;

    const string mixerMusic = "MusicVolume";
    const string mixerSFX = "SFXVolume";
    const string mixerMaster = "MasterVolume";
    private void Awake()
    {
        musica.onValueChanged.AddListener(SetMusicVolume);
        sfx.onValueChanged.AddListener(SetSFXVolume);
    }
    public void SetMusicVolume(float valor)
    {
        mixer.SetFloat(mixerMusic, Mathf.Log10(valor)*20);
    }
    public void SetSFXVolume(float valor)
    {
        mixer.SetFloat(mixerSFX, Mathf.Log10(valor) * 20);
    }
    public void SetMasterVolume(float valor)
    {
        mixer.SetFloat(mixerMaster, Mathf.Log10(valor) * 20);
    }
}