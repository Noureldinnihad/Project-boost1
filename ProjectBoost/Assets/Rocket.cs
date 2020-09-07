using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody rigidbody;
    AudioSource audio;
    [SerializeField] float rcsThrust = 300f;
    [SerializeField] float thrust = 100f;
    void Start()
    {
        rigidbody= GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Thrust();
        Rotation();

    }
     void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag){

            case "Friendly":
                print("ok");
                break;
            case "Dead":
                print("Dead");
                break;

        }
    }

    void Thrust()
    {
        float thrustThisFrame = thrust * Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
        {
            rigidbody.AddRelativeForce(Vector3.up*thrustThisFrame);
            if (!audio.isPlaying)
            {
                audio.Play();
            }

        }
      
       else  if (Input.GetKey(KeyCode.S))
        {
            rigidbody.AddRelativeForce(Vector3.down*thrustThisFrame);
            if (!audio.isPlaying)
            {
            audio.Play();
            }
           

        }
        else
        {
            audio.Stop();
        }
       

    }

    private void Rotation()
    {
        
        float rotationThisFrame = rcsThrust * Time.deltaTime;

        rigidbody.freezeRotation = true;
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(-Vector3.forward*rotationThisFrame);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.forward*rotationThisFrame);
        }
        rigidbody.freezeRotation = false;
    }
}


