using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    float horinzontalInput;
    float verticalInput;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horinzontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


        transform.Translate(Vector3.forward * horinzontalInput * Time.deltaTime);
        transform.Rotate(Vector3.forward * horinzontalInput *  Time.deltaTime);

    }
}
