using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(0, 5 * Time.deltaTime, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
