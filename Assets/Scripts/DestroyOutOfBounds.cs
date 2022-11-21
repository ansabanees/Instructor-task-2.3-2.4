using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    
    private float lowerBound = -7.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Square obstacles are vanished after they cross -7 on y-axis
        if (transform.position.y < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
