using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Start() {
        
    }
    private void Awake() {
    if (instance != null && instance != this)
{          
      Destroy(gameObject);
}
else
{
      instance = this;
      DontDestroyOnLoad(this.gameObject);
}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
