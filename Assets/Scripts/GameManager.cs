using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject[] PhotosCorck;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivatePhoto()
    {
        for (int i = 0; i < PhotosCorck.Length; i++)
        {
            if (!PhotosCorck[i].activeSelf) // !!!! se activan todas
            {
                PhotosCorck[i].SetActive(true);
            }
        }
    }
}
