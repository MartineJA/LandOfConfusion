using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CubeRotate : MonoBehaviour
{

    float speed = 5f;
    



    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region COURS (pas compris)
        /* Rigidbody rb = GetComponent<Rigidbody>();
         // GetComponent<Rigidbody>().rotation = Quaternion.identity;

         float horizontal = Input.GetAxis("Horizontal");
         float vertical = Input.GetAxis("Vertical");

         float speed =10;

         Vector3 direction = transform.right;
         Vector3 dir = new Vector3(horizontal, vertical,0);

         //Quaternion rotation = Quaternion.LookRotation(dir);

         direction = direction.normalized; // direction normalisée cf vid vers 5:40 stick droit

         Debug.DrawRay(transform.position, direction * 5, Color.red);

         //rb.MoveRotation(Quaternion.FromToRotation(transform.position, direction));

         rb.MovePosition(transform.position + dir * Time.deltaTime * speed * horizontal);

         //rb.rotation = rotation;*/
        #endregion


      


       

        /* //Debug.DrawRay(transform.position, mouvement * 5, Color.red);
         transform.rotation = Quaternion.FromToRotation(Vector3.forward, mouvement);

         rb.MovePosition(transform.position);*/
        
       

    }

    private void LateUpdate()
    {
        
    }

    private void FixedUpdate()
    {

        #region SOLO : mouvement basique basé sur player inputs
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float verticalArrow = Input.GetAxis("Debug Vertical");
        float horizontalArrow = Input.GetAxis("Debug Horizontal");


        Vector3 mouvement = new Vector3(horizontal, 0, vertical);
        transform.Translate(mouvement.normalized * Time.deltaTime * speed);

        Vector3 direction = new Vector3(horizontalArrow, 0, verticalArrow);
        #endregion


        Rigidbody rb = GetComponent<Rigidbody>();
       Quaternion rotation;
       rotation = Quaternion.LookRotation(direction,Vector3.up);

        //transform.rotation = Quaternion.FromToRotation(Vector3.forward, direction);

        rb.MoveRotation(rotation);
    }
}
