using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PlayerInput))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _walkspeed = 5f;

    Vector2 moveInput;

    Rigidbody2D rb;
    PlayerInput playerInput;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerInput = GetComponent<PlayerInput>();
    }
    



    void FixedUpdate()
    { 
        rb.velocity = new Vector3(moveInput.x * _walkspeed, rb.velocity.y);
    }

    
    public void OnMove(InputAction.CallbackContext context)
    {

        moveInput = context.ReadValue<Vector2>();
    }
}