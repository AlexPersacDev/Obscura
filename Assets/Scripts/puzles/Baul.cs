using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baul : MonoBehaviour
{
    [SerializeField] float speed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Opening();
    }

    void Opening()
    {
        if (transform.eulerAngles.x > -45)
        {
            transform.Rotate(Vector3.left * speed * Time.deltaTime);

        }
    }
}
