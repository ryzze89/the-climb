using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Add some code here that confers a benefit to the player

        Destroy(gameObject);
    }
}
