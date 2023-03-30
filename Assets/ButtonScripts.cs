using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{
    // Start is called before the first frame update
    public void QuitTheApp()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
    public void LaunchPaddle() 
    {
        SceneManager.LoadScene(1);
    }
    public void GoHome()
    {
        SceneManager.LoadScene(0);
    }
}
