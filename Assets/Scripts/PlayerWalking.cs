using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalking : MonoBehaviour
{
    public float moveSpeed = 10f;  
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");


        Vector3 movement = new Vector3(horizontalMovement, 0f, verticalMovement).normalized;
            MovePlayer(movement);
            RotatePlayer(movement);
          
        
    }

    void MovePlayer(Vector3 direction)
    {
        Vector3 newPosition = transform.position + direction * moveSpeed * Time.deltaTime;
        rb.MovePosition(newPosition);
        
    }
    void RotatePlayer(Vector3 direction)
    {
        if (direction != Vector3.zero)
        {
            transform.forward = direction;
        }
    }
}
