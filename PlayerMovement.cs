using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movespeed = 10f; //Player movement speed
    public float rotatespeed = 75f; //Player rotation speed

    private float vInput; //Vertical Input
    private float hInput; //Horizontal Input

    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        vInput = Input.GetAxis("Vertical") * movespeed;
        hInput = Input.GetAxis("Horizontal") * movespeed;

        this.transform.Translate(Vector3.forward * vInput * Time.deltaTime); // movement
        this.transform.Rotate(Vector3.up * hInput * 10 * Time.deltaTime); // rotation
    }

    /*void FixedUpdate()
    {
        Vector3 rotation = Vector3.up * hInput;
        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);
        _rb.MovePosition(this.transform.position + this.transform.forward * vInput * Time.fixedDeltaTime);
        _rb.MoveRotation(_rb.rotation * angleRot);
    }*/
}
