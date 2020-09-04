﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        processInput();


    }

  void processInput(){
if (Input.GetKey(KeyCode.Space))
{
    rigidbody.AddRelativeForce(Vector3.up);
}
if (Input.GetKey(KeyCode.A))
{
            rigidbody.AddRelativeForce(Vector3.right);
}
if (Input.GetKey(KeyCode.D))
{
            rigidbody.AddRelativeForce(Vector3.left);
}







   }
}


