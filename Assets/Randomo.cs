using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomo : MonoBehaviour
{
    public BoxCollider2D box;
    

    // Start is called before the first frame update
    void Start()
    {
        Rando();


    }

    // Update is called once per frame
    void Update()
    {
        // float numberOfPlatforms = 4;
        // float y = -2;
        // float x = -5;

        // float boxX = land.transform.position.x;
        // float boxY = land.transform.position.y;

        

    }

    void Rando(){
        for (int i = 0; i<3; i++) {
            transform.position = new Vector2(transform.position.x + i, Random.Range(transform.position.y-2, transform.position.y+2));
            
        }
    }

    void Move(){
        for (int i = 0; i<3; i++) {
            transform.position = new Vector2(transform.position.x + i, transform.position.y);
        }
    }
}
