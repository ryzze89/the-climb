using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 2; i < 101; i+=2)
        {
            Debug.Log(i);
        }

        for (int i = 1; i < 101; i += 2)
        {
            Debug.Log(i);
        }

        for (int i = 0; i > -1001; i-- )
        {
            Debug.Log(i);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
