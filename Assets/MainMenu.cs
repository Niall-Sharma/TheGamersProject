using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public int index;
    public void startGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void quitGame(){
         Debug.Log("QUIT!");
         Application.Quit();
    }


    public void LevelSelect(int index){
        SceneManager.LoadScene(index);

}
}