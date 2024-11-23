using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 20;
    public float jumpForce = 20;
    public float gravityForce = -40;
    private bool isOnGround = false;
    public Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0, gravityForce, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Move();

    }

    void Move()
    {
        if (isOnGround)
        {
            float verticalInput = Input.GetAxis("Vertical");
            float horizontalInput = Input.GetAxis("Horizontal");

            //Move player
            playerRb.AddForce(Vector3.forward * verticalInput * speed);
            playerRb.AddForce(Vector3.right * horizontalInput * speed);

            //Rotate in movement direction (if input 0 leave looking to last direction
            Vector3 movementDirection = new Vector3(horizontalInput, 0f, verticalInput);
            if (movementDirection != Vector3.zero)
            {
                transform.forward = movementDirection;
                playerRb.angularVelocity = movementDirection * speed;
            }

            //Jump
            if (Input.GetKeyDown(KeyCode.Space))
            {
                playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
    void OnCollisionStay(Collision collision)

    {

        isOnGround = true;
    }

}
