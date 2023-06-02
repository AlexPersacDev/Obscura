using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [Header("SFX")]
    [SerializeField] AudioClip[] audioClips;
    AudioClip currentClip;
    [SerializeField]AudioSource aS; 
    
    [Header("Music")]
    [SerializeField] AudioClip[] musicClips;
    AudioClip currentMusic;
    [SerializeField]AudioSource aSMusic; 


    void Start()
    {
        StartCoroutine(RandomSound());
        StartCoroutine(RandomMusic());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RamdonSound()
    {

        int index = Random.Range(0, (audioClips.Length + 1)); // randomizo indice del array y lo meto en variable
        currentClip = audioClips[index];
        aS.clip = currentClip;// pone en el audio source el clip randomizado
        aS.Play();// lazo el clip
    }
    
    IEnumerator RandomSound()
    {
        while (true)
        {
            RamdonSound();
            float randomTime = Random.Range(90, 181);
            yield return new WaitForSeconds(randomTime);
        }

    }

    IEnumerator RandomMusic()
    {
        while (true)
        {
            int index = Random.Range(0, (musicClips.Length + 1));
            currentMusic = musicClips[index];
            aSMusic.clip = currentMusic;
            aSMusic.Play();

            float RandomMusic= Random.Range(180, 301);
            yield return new WaitForSeconds(RandomMusic);
            
        }
    }
}
