using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
  //  public Object thisObject;
    public BoxCollider2D bc; //the hitbox of the collectible

// private void Awake()
// {

// } 

void Start()
    {
//make them appear here
    
    }

    // Update is called once per frame
    void Update()
    {
        // collectibles wabble a bit?
        // make them pickupable 
            // if player touches it, it disappears and ??
        if(collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}