using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public KeyCode upkey;
    public KeyCode downkey;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
      
       rigidBody = GetComponent<Rigidbody2D>();
   
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(upkey) && transform.position.y < 5)
        {
            rigidBody.velocity = Vector2.up * speed;
        }
        else if (Input.GetKey(downkey) && transform.position.y < 5)
        {
            rigidBody.velocity = Vector2.down * speed;
        }
        else
        {
            rigidBody.velocity = Vector2.zero;
        }
    }
}
