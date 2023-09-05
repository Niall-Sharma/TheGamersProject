using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagment;

public class Menucode : MonoBehaviour
{
    
    public void PlayGame()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
            
    }

    public void QuitGame(){
        
    }
 }
