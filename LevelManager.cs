using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
     public void Quitgame()
     {
         Application.Quit();
     }
    
}
