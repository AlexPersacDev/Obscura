using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackOut : MonoBehaviour
{
    Animator anim;
    [SerializeField] GameObject creditos;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void BlackOuting()
    {
        anim.SetBool("Black", true);
    }
    public void Creditos()
    {
        creditos.SetActive(true);
    }
}
