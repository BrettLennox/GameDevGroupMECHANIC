using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   
    public float moveSpeed = 4;
    public float score;
    public float jumpSpeed =  4;
    public bool grounded = true;

    private Vector2 moveDir;
 
    public Rigidbody rb;

    


    // Update is called once per frame
    void Update()
    {
        moveDir = new Vector2(Input.GetAxisRaw("Horizontal"), 0f); //stores Horizontal Axis input within moveDir Vector2

        //normalizes the moveDir Vector if its magnitude is greater then 0.1f
        if (moveDir.magnitude >= 0.1f)
        {
            moveDir = moveDir.normalized;
        }
        transform.Translate((moveDir * moveSpeed) * Time.deltaTime); //applies moveDir * moveSpeed to transform

        if (Input.GetKeyDown(KeyCode.Space) && grounded) //if Space is pressed and grounded is true
        {
            grounded = false; //sets grounded to false
            rb.AddForce(0, 1 * jumpSpeed, 0, ForceMode.Impulse); //applies force on the y axis * jumpSpeed, with Impulse ForceMode
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        grounded = true; //OnCollision set grounded to true
    }

    

   


}
