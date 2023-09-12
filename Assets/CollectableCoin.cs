using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCoin : Collectables
{
    public CoinTracker counter;
    public CoinTracker addCoin;

void Start(){}

void Update(){}

    void OnTriggerEnter2D(){
        counter.addCoin(1);
    }

}