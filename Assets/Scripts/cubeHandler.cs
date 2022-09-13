using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeHandler : MonoBehaviour
{
    public Rigidbody cubeRB;
    public BoxCollider boxCollider;
    public static bool hasCube;
    public static GameObject expansiveCube;
    public static GameObject cubeSpawn;
    public static GameObject newCube;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "ExpansiveCube")
        {
            //The cube will become a child of the collided object.
            //If there is another cube destroy it first
        }

    }

   


    public static void useCube()
    {
        if (hasCube)
        {
            newCube = Instantiate(expansiveCube, cubeSpawn.transform.position, cubeSpawn.transform.rotation);
            hasCube = false;
        }
        else
        {
            Destroy(newCube, 0.1f);
            hasCube = true;
        }

    }

   
}
