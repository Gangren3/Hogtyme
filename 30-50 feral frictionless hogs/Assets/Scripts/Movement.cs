using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //private Rigidbody rb;
    private Vector3 rotation;

    public CharacterController control;

    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * Time.deltaTime * 20, 0);

        Vector3 move = new Vector3(0, 0, Time.deltaTime * 10);
        move = transform.TransformDirection(move);
        control.Move(move * 1);
        transform.Rotate(this.rotation);
    }
}
