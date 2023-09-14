using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random : MonoBehaviour
{
    public BoxCollider2D box;
    

    // Start is called before the first frame update
    void Start()
    {
        Move();
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

    void Move(){
        for (int i = 0; i<10; i++) {
            transform.position = new Vector2(transform.position.x + i, transform.position.y);
        }
    }
}
