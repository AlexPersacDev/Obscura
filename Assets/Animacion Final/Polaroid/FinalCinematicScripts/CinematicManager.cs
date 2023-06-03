using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicManager : MonoBehaviour
{
    [SerializeField] PlayerLook look;
    [SerializeField] GameObject cameraPlayer;
    [SerializeField] GameObject camera2;
    void Update()
    {
        look.enabled = false;
    }
}
