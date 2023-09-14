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
    string xholder;
    
void Start(){

displayNum.text = "000";
n = counter.getNum();
xholder = "000";
}

void Update(){
    n=counter.getNum();
    x = n.ToString();
    
    if(string.Equals(x, xholder) ){

    }
    else{
    displayNum.text = x;
    xholder = x;
    }
}

}