using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // declare public/private variables
    public Rigidbody rb;
    public float speed = 2000f;
    public float jumpForce = 2000f;
    public float gravityModifier;
    public bool isOnGround = true;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();  
    }

    // player controls
    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            rb.AddForce(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey("space") && isOnGround)
        {
            rb.AddForce(Vector3.up * jumpForce);
            isOnGround = false;
        }
    }

          
        

    
    // Update is called once per frame
    void Update()
    {
        

    }
}