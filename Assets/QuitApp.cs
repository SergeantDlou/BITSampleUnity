using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApp : MonoBehaviour
{
    public void QuitTheApp() 
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
