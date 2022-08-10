using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    
    public void yes(){
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Scene/Game");
    }
    public void no(){
        Application.Quit();
    }


}
