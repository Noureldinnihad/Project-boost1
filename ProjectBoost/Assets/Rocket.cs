using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody rigidbody;
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody= GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
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
            if (!audio.isPlaying)
            {
audio.Play();
            }
            
}
        else
        {
            audio.Stop();
        }
if (Input.GetKey(KeyCode.A))
{
            transform.Rotate(Vector3.forward);
}
if (Input.GetKey(KeyCode.D))
{
            rigidbody.AddRelativeForce(-Vector3.forward);
}







   }
}


