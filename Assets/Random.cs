using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random : MonoBehaviour
{
    public BoxCollider2D box;
    public GameObject land;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float numberOfPlatforms = 4;
        float y = -2;
        float x = -5;

        float boxX = land.transform.position.x;
        float boxY = land.transform.position.y;

        
        for (int i = 0; i<10; i++) {
            land.transform.position = new Vector2(land.transform.position.x + i*1000, land.transform.position.y);
        }
    }
}
