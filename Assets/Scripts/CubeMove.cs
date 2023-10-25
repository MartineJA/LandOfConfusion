using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    #region VARIABLES

    float speed = 8f;
    int angle = 360;
    
   
    

    #endregion

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Awake()
    {
        
    }

    private void FixedUpdate()
    {   // on peut pas mettre ci-dessous ailleurs:
        Rigidbody rb = GetComponent<Rigidbody>();
        

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");


        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);
        
        


        if (direction == Vector3.zero)
        {
            return;
        }

        Quaternion quaternion = Quaternion.LookRotation(direction);
        quaternion = Quaternion.RotateTowards(transform.rotation, quaternion, angle * speed * Time.fixedDeltaTime);

        rb.MovePosition(transform.position + direction * speed * Time.fixedDeltaTime);
        rb.MoveRotation(quaternion);
        

        Debug.DrawRay(transform.position, direction * 10, Color.red);
    }
}
