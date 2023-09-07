using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    
    public void startGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void quitGame(){
         Debug.Log("QUIT!");
         Application.Quit();
    }


    public void Level1(){
        SceneManager.LoadScene(1);
    }
    public void Level2(){
        SceneManager.LoadScene(2);
    }
    public void Level3(){
        SceneManager.LoadScene(3);
    }
    public void Level4(){
        SceneManager.LoadScene(4);
    }
    public void Level5(){
        SceneManager.LoadScene(5);
    }

}
