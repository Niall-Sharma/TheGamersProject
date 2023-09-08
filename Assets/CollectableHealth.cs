using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableHealth : Collectables
{
    public playerHealth health;
public playerHealth addHealth;

void Start(){}

void Update(){}

    void OnTriggerEnter2D(){
        health.addHealth(1);
    }

}