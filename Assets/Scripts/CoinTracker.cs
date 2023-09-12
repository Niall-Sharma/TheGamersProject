using UnityEngine;
using System;
using UnityEngine.Audio;

public class CoinTracker : MonoBehaviour
{
public float counter;
    // Start is called before the first frame update
    
public void addCoin(int toAdd){
    counter += toAdd;
}

    void Start() {
        counter = 0;
    }
    // Update is called once per frame
    void Update()
    {
        
    }


}
