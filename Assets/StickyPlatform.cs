using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform: MonoBehaviour
{
    // Start is called before the first frame update
    private void OncollisionEnter (Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.transform.parent = transform;
        }
    }

    // Update is called once per frame
    private void OnCollisionExit (Collision collision)
    {
      if (collision.gameObject.tag == "player")
        {
            collision.transform.parent = null;
        }  
    }
}
