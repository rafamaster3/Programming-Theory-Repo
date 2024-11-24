using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Player // INHERITANCE
{

    public override void Action() // POLYMORPHISM
    {
        Jump(); // ABSTRACTION
    }
    void Jump() 
    {
        //Jump
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}


