using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet001 : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;
    public Transform bulletGroup;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void Update()
    {
        // bool spacePressed = Input.GetButtonDown("Jump");
        bool spacePressed = Input.GetKeyDown(KeyCode.Space);
        


        if (spacePressed)
        {
            // Object.Instantiate(bullet, Vector3.zero, transform.rotation, bulletPos) ; // fonctionne pas
            // Object.Instantiate(bullet);

            //newBullet.transform.parent = bulletPos;



            // création du clone 
            GameObject bulletClone = Object.Instantiate(bullet);

            bulletClone.transform.parent = bulletPos;
            bulletClone.transform.position = Vector3.zero;


            bulletClone.transform.rotation = transform.rotation;


            bulletClone.transform.parent = bulletGroup;
            Debug.Log(spacePressed); // ok
        }



    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

     
    }

   
}
