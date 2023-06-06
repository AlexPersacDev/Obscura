using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicManager : MonoBehaviour
{
    [SerializeField] PlayerLook look;
    [SerializeField] GameObject cameraPlayer;
    [SerializeField] GameObject camera2;
    [SerializeField] GameObject monster;
    [SerializeField] GameObject cam;
    [SerializeField] GameObject player;
    void Update()
    {
        look.enabled = false;
        cam.SetActive(false);
        player.SetActive(false);
    }
    public void Cumera()
    {
        cameraPlayer.SetActive(false);
        camera2.SetActive(true);
    }
}
