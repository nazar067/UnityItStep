using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 15;
    public CharacterController controller;
    private Vector3 moveX;
    private Vector3 moveZ;
    void Start()
    {
        
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        moveX = transform.right * x;
        moveZ = transform.forward * z;

        controller.Move(moveX * speed * Time.deltaTime);
        controller.Move(moveZ * speed * Time.deltaTime);
    }
}
