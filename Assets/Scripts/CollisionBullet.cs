using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CollisionBullet : MonoBehaviour
{
    public GameObject enemyToDestroy;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("ok, balle détruite");
        Destroy(gameObject);
        score++;
        //
        //Debug.Log(score);

        if (score == 5) { Debug.Log("score bon"); Destroy(enemyToDestroy); }
        

        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger, autre objet détruit");
        Destroy(other.gameObject);
    }
}
