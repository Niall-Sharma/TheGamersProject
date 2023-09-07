using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    public BoxCollider2D pickupBox;
    public GameObject thisObject;

 // private Object thisObject;
//  private void Awaken(){
//    
  //}
 void Start(){}
 void Update(){}
 void OnTriggerEnter2D(){
    Destroy(thisObject);
 }

}