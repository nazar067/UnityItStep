using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            print("next level");
            if(SceneManager.GetActiveScene().name == "Level 1")
                SceneManager.LoadScene("Level 2");
            if (SceneManager.GetActiveScene().name == "Level 2")
                SceneManager.LoadScene("Level 1");
        }
    }
}
