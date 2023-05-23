using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Openeable : MonoBehaviour
{
    Animator anim;
    bool isOpen;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IsOpened()
    {
        if (!isOpen)
        {
            anim.SetTrigger("Opening");
            isOpen = true;
        }
        else
        {
            anim.SetTrigger("Close");
            isOpen = false;
        }
    }
}
