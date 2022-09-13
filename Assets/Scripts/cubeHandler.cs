using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeHandler : MonoBehaviour
{
    public Rigidbody cubeRB;
    public BoxCollider boxCollider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
       // gameObject.transform.position = other.gameObject.tag("Spawn Location");
    }
}
