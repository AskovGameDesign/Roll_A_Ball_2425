using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 5;
    public float jumpForce = 5;

    float zMovement;
    float xMovement;
    Vector3 movement;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        zMovement = Input.GetAxis("Vertical");
        xMovement = Input.GetAxis("Horizontal");
        movement = new Vector3(xMovement, 0, zMovement);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(movement * speed);
    }
}
