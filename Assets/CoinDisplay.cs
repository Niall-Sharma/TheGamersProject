using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinDisplay : MonoBehaviour
{
    public CoinTracker counter;
    public CoinTracker getNum;
    int n;
    public Text displayNum;
    string x;
    
void Start(){

displayNum.text = "000";
n = counter.getNum();
}

void Update(){
    n=counter.getNum();
    x = n.ToString();
displayNum.text = x;
}

}