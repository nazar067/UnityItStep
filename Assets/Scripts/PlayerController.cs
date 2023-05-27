using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 15;
    public CharacterController controller;
    private Vector3 move;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
    }
}
