using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
       rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
           
            rigidBody.AddForce(Vector3.up * 21, ForceMode.Impulse);
          
        }
        
        
       
    }
}
