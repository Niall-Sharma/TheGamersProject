using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{

    public int health;


    public void takeDamage(int damage){
        health -= damage;
        Debug.Log("PLAYER HEALTH: " + health);
        if(health <= 0){
            playerDie();
        }
    }

    public void playerDie(){
        Destroy(this);
    }

    public void addHealth(int x){
        health+=x;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
