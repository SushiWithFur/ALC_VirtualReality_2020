using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 45f;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody playerRb;
    public float moveForce;
    public float jumpForce;
    private GameObject focalPoint;
    

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);

        horizontalInput = Input.GetAxis("Horizontal");
        //// Moves the car forward based on vertical input
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Moves the car based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        if (Input.GetKeyDown(KeyCode.Space))
        {
          playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

        }
        //  if (Input.GetKeyDown(KeyCode.LeftShift))
        // {
        //      transform.Translate(Vector3.forward * Time.deltaTime * (speed * 2) * forwardInput);
        //  }



    }
}
