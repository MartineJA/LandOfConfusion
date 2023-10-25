using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    // Start is called before the first frame update
   
    

    private void Update()
    {
 
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
        
    }

    
}
