using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        // Check if the colliding object has the tag Note1 or Note2
        if (coll.gameObject.tag == "Note1" || coll.gameObject.tag == "Note2")
        {
            // Destroy the colliding object
            Destroy(coll.gameObject);
        }
    }
}
