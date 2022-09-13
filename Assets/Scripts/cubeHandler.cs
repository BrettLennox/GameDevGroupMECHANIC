using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeHandler : MonoBehaviour
{
    public Rigidbody cubeRB;
    public BoxCollider boxCollider;
    public static bool hasCube;
    public GameObject expansiveCube;
    public static GameObject cubeSpawn;
    public static GameObject newCube;

    public List<GameObject> cubes;
    public static CubeHandler SharedInstance;

    private void Awake()
    {
        SharedInstance = this;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "ExpansiveCube")
        {
            //The cube will become a child of the collided object.
            //If there is another cube destroy it first
        }

    }

   


    public void UseCube(Transform transform)
    {
        GameObject newCube = Instantiate(expansiveCube, transform.position, transform.rotation);
        cubes.Add(newCube);
        if(cubes.Count > 1)
        {
            for(int i = 0; i < cubes.Count; i++)
            {
                Destroy(cubes[i].gameObject);
                cubes.RemoveAt(i);
            }
        }



        //if (hasCube)
        //{
        //    newCube = Instantiate(expansiveCube, transform.position, transform.rotation);
        //    hasCube = false;
        //}
        //else
        //{
        //    Destroy(newCube, 0.1f);
        //    hasCube = true;
        //}

    }

   
}
