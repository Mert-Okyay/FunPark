using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    float x;
    float z;
    public float speed = 12f;

    Boolean gravityOn;
    public CharacterController controller;
    public Rigidbody characterBody;
    void Start()
    {
        gravityOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        /*if (Input.GetKeyDown("space"))
        {
            if(gravityOn){
                characterBody.useGravity = false;
            }
            else
            {
                characterBody.useGravity = true;
            }
            
        }*/

        if(Input.GetKeyDown("h")){
            transform.localPosition = new Vector3(0f,0.39f,-166.7f);
        }

        if (Input.GetKeyDown("x"))
        {
            Application.Quit();
        }
    }
}
