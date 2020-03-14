using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    //public Rigidbody theR3;
    public float jumpForce;
    public CharacterController controller;

    private Vector3 moveDirection;
    public float gravityScale;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, moveDirection.y, Input.GetAxis("Vertical") * moveSpeed); //controller.transform.position.y
        if (controller.isGrounded)
        {
            moveDirection.y = 0f;
        }
        if (Input.GetButton("Jump"))
        {
            moveDirection.y = jumpForce;
        }
        moveDirection.y += (Physics.gravity.y * Time.deltaTime * gravityScale);
        controller.Move(moveDirection*Time.deltaTime);
    }
}
