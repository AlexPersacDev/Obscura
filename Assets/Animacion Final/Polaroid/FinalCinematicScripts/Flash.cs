using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Flash : MonoBehaviour
{
    Animator anim;
    bool activar;
    [SerializeField] CinematicManager cinematicManager;
    [SerializeField] AudioSource monster;
    [SerializeField] BlackOut black;
    private void Start()
    {
        anim = GetComponent<Animator>();
        activar = true;
    }
    void Update()
    {
        if (activar)
        {
            anim.SetBool("Activar", true);
        }
    }
    public void Death()
    {
        Destroy(gameObject);
    }
    public void Cambio()
    {
        cinematicManager.Cumera();
    }
    private void OnDestroy()
    {
        monster.Play();
        black.BlackOuting();
    }
}
