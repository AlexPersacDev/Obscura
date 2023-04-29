using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    CharacterController controlerPlayer;

    [SerializeField] float jumplength, speed, gravityScale, piesRad;
    [Header("CheckSphere")]
    [SerializeField] Transform pies;
    [SerializeField] LayerMask whatIsGround;

    //Gravity
    Vector3 moveY = Vector3.up;//recoge la info del mov en y tanto gravedad como salto

    void Start()
    {
        controlerPlayer = GetComponent<CharacterController>();
    }

    void Update()
    {
        Movement();
        Gravity();

        if (isGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Movement()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 localMovementDirecction = transform.forward * v + transform.right * h; //consigues movimiento en direcciones locales
        controlerPlayer.Move(localMovementDirecction * speed * Time.deltaTime);
    }

    void Gravity() //la gravedad se va incrementando por frame
    {
        moveY.y += gravityScale * Time.deltaTime;   //muevo al controler en Y basandome en esa gravedad
        controlerPlayer.Move(moveY * Time.deltaTime);
    }

    bool isGrounded()
    {
        return Physics.CheckSphere(pies.position, piesRad, whatIsGround);
    }

    void Jump()
    {
        bool isOnGround = isGrounded();
        if (isOnGround)
        {
            moveY.y = 0;
        }
        float jumpign = Mathf.Sqrt(-2 * gravityScale * jumplength);
        moveY = new Vector3(0, jumpign, 0);
    }
}
