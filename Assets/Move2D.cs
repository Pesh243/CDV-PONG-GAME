using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2D : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
            
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = Vector2.one;

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }
}
