using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   
    public float moveSpeed = 4;
    public float score;
    public float jumpSpeed =  4;
    public bool grounded = true;
 
    public Rigidbody rb;
    
    

    //public float 

    


    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        //float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, transform.position.y, 0f).normalized;

        if (direction.magnitude >= 0.1f)
        {

            transform.position += direction.normalized * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKeyDown("space") && grounded)
        {
            grounded = false;
            Debug.Log("You jumped!");   
            rb.AddForce(Vector3.up * jumpSpeed);

        }


        if (Input.GetKeyDown(KeyCode.F))
        {
            CubeHandler.SharedInstance.UseCube(this.transform);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        grounded = true;
    }

    

   


}
