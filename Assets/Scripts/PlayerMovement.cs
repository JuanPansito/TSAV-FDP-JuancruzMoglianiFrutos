using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;

    public Animator animator;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpForce = 100f;

    public Transform groundCheck;
    public float groundDistance = 0.4f; 
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        animator.SetFloat("Xmove", x);
        animator.SetFloat("Zmove", z);

        animator.SetBool("walk", math.abs(z) + math.abs(x) > 0);

        

    }
}
