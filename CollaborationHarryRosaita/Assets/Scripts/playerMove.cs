using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    Rigidbody rb;
    public float playerSpeed = 5f;
    Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        moveDirection = new Vector3(horizontalInput * playerSpeed, -9.8f, 0);
    }

    private void FixedUpdate()
    {
        rb.velocity = moveDirection;
    }
}
