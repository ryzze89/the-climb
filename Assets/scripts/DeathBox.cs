using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(9);
        if (other.gameObject.tag == "Player")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
    }
}
