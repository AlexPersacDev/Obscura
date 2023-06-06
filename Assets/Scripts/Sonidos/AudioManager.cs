using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [Header("SFX")]
    [SerializeField] AudioClip[] audioClips;
    AudioClip currentClip;
    [SerializeField]AudioSource aS; 
    
    [Header("Music")]
    [SerializeField] AudioClip[] musicClips;
    AudioClip currentMusic;
    [SerializeField]AudioSource aSMusic;

    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
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
        aS.PlayOneShot(currentClip);
    }
    public void Music()
    {
        int index = Random.Range(0, (musicClips.Length + 1));
        currentMusic = musicClips[index];
        aSMusic.clip = currentMusic;
        aSMusic.Play();
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
            Music();
            float RandomMusic= 120f;
            yield return new WaitForSeconds(RandomMusic);
            
        }
    }
}
